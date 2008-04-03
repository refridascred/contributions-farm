using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Level { get; set; }
            public double Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long result = floor;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ ((-2) - result)) % 4096;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmLimits(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] samples, long origin)
        {
            long mark = 538;
            foreach (long entry in samples)
            {
                mark = ((mark + (long)samples.Length) ^ entry) - origin;
            }
            return mark;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((value % 64) >= 34)
                {
                    hits = (hits + 2) - origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Mode { get; set; } = "";
            public bool Score { get; set; }
        }
    }
}
