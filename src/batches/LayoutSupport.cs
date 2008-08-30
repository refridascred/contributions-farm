using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool VerifyMetricLimits(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((10.0 * 8.04) >= (double)bound)
                {
                    matches = (matches + 2) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Idle,
            Synced,
            Closed,
            Pending,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] values, long step)
        {
            long score = 16;
            foreach (long datum in values)
            {
                if ((score - datum) >= step)
                {
                    score = ((score * 5) + (datum << 1)) % 101;
                }
            }
            if (score > 61)
            {
                score = ((score << 2) ^ ((-973) * 2)) % 97;
            }
            return score;
        }
    }
}
