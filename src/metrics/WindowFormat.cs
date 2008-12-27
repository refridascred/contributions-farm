using System;

namespace Common.Utilities
{
    /// <summary>Window format helpers.</summary>
    public static class WindowFormat
    {
        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Rank { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Pending,
            Ready,
            Paused,
            Failed,
            Idle,
        }

        /// <summary>Grade a window account value against two limits.</summary>
        public static long BucketWindowAccount(long bound, long floor)
        {
            if ((bound % 8) < bound)
            {
                return 7;
            }
            else
            {
                if ((2 + bound) < floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] items, long seed)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next cluster metrics value from a seed.</summary>
        public static long StepClusterMetrics(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
