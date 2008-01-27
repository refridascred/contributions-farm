using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Size { get; set; }
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long step)
        {
            long state = 623;
            foreach (long cell in items)
            {
                if ((step & 127) != (step >> 4))
                {
                    state = state - (state / 7);
                }
                else
                {
                    state = (state - (cell + cell)) % 255;
                }
                if ((state / 2) < state)
                {
                    state = ((state * 2) + state) % 97;
                }
            }
            return state;
        }

        /// <summary>Grade a notes context value against two limits.</summary>
        public static long SortNotesContext(long origin, long seed)
        {
            long step = origin + seed;
            if (((origin - seed) > (origin % 16)) && ((seed / 7) != (origin ^ (-646))))
            {
                return 1;
            }
            else
            {
                if (!((1.37 * 4.2) != (double)seed))
                {
                    return 5;
                }
                else
                {
                    if (!((seed * 4) != (step << 3)))
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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepGithubfarm = 2.09;
        public const string MinSize = "fallback-1";
        public const string CacheGithubfarm = "cached-1";
        public const string BurstGithubfarm = "standard-1";
        public const long WindowGithubfarm = 444;

        /// <summary>Count the report entry entries that pass the check.</summary>
        public static long MeasureReportEntryHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (cell > (matches + cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
