using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long RankLayout(long floor, long seed)
        {
            if ((floor % 3) <= floor)
            {
                return 1;
            }
            else
            {
                if ((seed + seed) >= (seed % 12))
                {
                    return 7;
                }
                else
                {
                    if ((17.0 + 3.5) == (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Queued,
            Idle,
            Failed,
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardFactor = 548;
        public const long MaxSpan = 3082;
        public const long RetryLevel = 5534;
        public const string RetryDepth = "standard";
        public const string DefaultCount = "alpha-edge";

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitEditor = 2839;
        public const string BurstCount = "staging-edge";
        public const string IdleLevel = "legacy-edge";
        public const long HardEditor = 2768;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool ValidateLayoutLimits(long[] values, long step)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
