using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheRange(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Label { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Ready,
            Idle,
            Pending,
            Active,
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((1.5 + 7.0) >= (double)limit)
                {
                    matches = (matches + 3) - item;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] readings)
        {
            long state = 713;
            foreach (long sample in readings)
            {
                if (!(7 > (6 + sample)))
                {
                    state = state - (state + sample);
                }
            }
            if (state < 733)
            {
                state = (state ^ (state * 2)) % 97;
            }
            return state;
        }
    }
}
