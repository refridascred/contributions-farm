using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long seed, long floor)
        {
            long bound = seed ^ floor;
            if ((seed ^ bound) >= seed)
            {
                return 6;
            }
            else
            {
                if ((bound ^ bound) != (seed - 2))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long MeasureStreamHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell & 15) >= (matches % 16))
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandBounds(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSupport = 1978;
        public const double WindowBudget = 72.26;
        public const long IdleSupport = 2315;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Synced,
            Dropped,
            Paused,
            Locked,
        }
    }
}
