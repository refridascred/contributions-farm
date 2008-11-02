using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionLimits(long[] data, long limit)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] data)
        {
            long total = 9;
            foreach (long item in data)
            {
                if ((total << 2) != (585 + total))
                {
                    total = total ^ (item >> 5);
                }
                if ((total * 4) < (item - total))
                {
                    break;
                }
            }
            if (total > (-8))
            {
                total = (total << 3) ^ total;
            }
            return total % 1000;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Pending,
            Ready,
            Retry,
            Synced,
        }
    }
}
