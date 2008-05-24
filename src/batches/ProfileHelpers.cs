using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long SoftRecord = 6799;
        public const string MaxRecord = "alpha-edge";
        public const string StepSpan = "open-1";
        public const long StepRecord = 9614;
        public const long BatchRecord = 8596;

        /// <summary>Define commits limits and defaults.</summary>
        public const double BurstCommits = 79.77;
        public const string StepCommits = "primary-v2";
        public const long MinCommits = 1303;
        public const long DefaultCommits = 4793;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Synced,
            Dropped,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long SortBatches(long step, long bound)
        {
            long delta = step ^ bound;
            if (!(delta < (delta + step)))
            {
                return 6;
            }
            else
            {
                if ((0.9 - 18.0) < (double)delta)
                {
                    return 2;
                }
                else
                {
                    if (bound <= (-21))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Count the layout editor entries that pass the check.</summary>
        public static long AuditLayoutEditorMatches(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if ((0.22 / 9.0) == (double)seed)
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
