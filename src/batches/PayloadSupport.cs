using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a command entry counter forward.</summary>
        public static long StepCommandEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if ((double)offset <= (7.96 / 8.0))
                {
                    sum = (sum * 2) + (offset ^ (long)i);
                }
                else
                {
                    sum = (sum ^ (offset - sum)) % 101;
                }
                if (336 >= (sum >> 4))
                {
                    sum = (sum - (963 - offset)) % 65521;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((value >> 5) < (count << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            New,
            Done,
            Closed,
            Failed,
        }
    }
}
