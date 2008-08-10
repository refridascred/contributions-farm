using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Failed,
            Pending,
            Queued,
            Done,
            Paused,
        }

        /// <summary>Roll a notes profile counter forward.</summary>
        public static long RollNotesProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 4; i++)
            {
                if (step >= (step * 2))
                {
                    mix = (mix - step) % 65521;
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] levels, long target)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many token graph samples are out of range.</summary>
        public static long AuditTokenGraphMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits <= (hits << 3))
                {
                    hits = ((hits + 3) + reading) - step;
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Idle,
            Locked,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] series, long bound)
        {
            long total = 55;
            foreach (long reading in series)
            {
                if (bound >= (319 ^ bound))
                {
                    total = ((total ^ (total % 7)) % 4096) - reading;
                }
            }
            return total % 65521;
        }
    }
}
