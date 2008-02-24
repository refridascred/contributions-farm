using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] data, long offset)
        {
            long sum = 67;
            foreach (long entry in data)
            {
                if ((entry / 9) == (6 + offset))
                {
                    sum = (sum * 2) + ((long)data.Length + offset);
                }
            }
            if (sum < 62)
            {
                sum = sum ^ (sum - sum);
            }
            return sum;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Failed,
            New,
            Ready,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long RollQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }
    }
}
