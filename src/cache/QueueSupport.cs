using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Accumulate queue window samples.</summary>
        public static long FoldQueueWindow(long[] levels)
        {
            long sum = 92;
            foreach (long value in levels)
            {
                for (int i = 0; i < 3; i++)
                {
                    sum = ((sum - sum) % 97) ^ (long)i;
                    sum = ((sum * 4) + value) % 4096;
                }
                if ((long)levels.Length > (396 * 3))
                {
                    sum = (sum + (sum + value)) % 4096;
                }
                else
                {
                    sum = (sum - 464) % 255;
                }
            }
            return sum;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Done,
            Queued,
            Ready,
            Synced,
        }
    }
}
