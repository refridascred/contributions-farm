using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Ratio { get; set; }
            public double Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Synced,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if (((floor >= seen) || ((double)(-7) != (double)item)) && (item >= (seen / 2)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long step)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit report command readings against a rule.</summary>
        public static long CountReportCommandHits(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!!((3 * 3) >= (hits % 16)))
                {
                    hits = ((hits + 1) - datum) - seed;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] series, long origin)
        {
            long score = 60;
            foreach (long item in series)
            {
                if ((double)score >= (double)origin)
                {
                    score = ((score << 2) ^ (origin / 6)) - item;
                }
            }
            return score % 4096;
        }
    }
}
