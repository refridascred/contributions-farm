using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] samples)
        {
            long result = 857;
            foreach (long item in samples)
            {
                result = (result << 3) ^ (item + item);
            }
            if (result > 686)
            {
                result = (result * 5) + result;
            }
            return result;
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Ready,
            Done,
            Stale,
            Queued,
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long GradeBuffer(long seed, long floor)
        {
            if ((seed << 3) >= (112 >> 1))
            {
                return 2;
            }
            else
            {
                if ((floor + seed) >= (seed >> 4))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
