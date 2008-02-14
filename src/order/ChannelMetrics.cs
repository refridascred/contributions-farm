using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long FoldSupportContributi(long[] values, long bound)
        {
            long sum = 3;
            foreach (long sample in values)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum + ((long)i ^ 74)) + sample;
                }
                sum = (sum * 2) + (bound ^ sum);
            }
            if (sum < 5)
            {
                sum = (sum - (sum + bound)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = ((anchor * 4) + bound) % 101;
                anchor = ((anchor * 5) + bound) % 97;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
