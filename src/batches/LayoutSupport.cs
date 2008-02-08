using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Pending,
            Active,
            Retry,
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (floor > (score + (long)i))
                {
                    score = (score * 3) + floor;
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Failed,
            Pending,
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Synced,
            Done,
            Locked,
        }

        /// <summary>Accumulate commits already samples.</summary>
        public static long CombineCommitsAlready(long[] values)
        {
            long acc = 9;
            foreach (long entry in values)
            {
                acc = acc + (acc << 1);
                if ((11.0 * 13.0) < (5.17 - 6.67))
                {
                    acc = (acc ^ entry) % 1000;
                }
            }
            return acc;
        }
    }
}
