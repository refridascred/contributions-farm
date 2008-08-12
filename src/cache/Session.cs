using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] levels, long limit)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                score = score - score;
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Digest a series of queue contributi entries.</summary>
        public static long FoldQueueContributi(long[] samples, long limit)
        {
            long state = 22;
            foreach (long sample in samples)
            {
                state = ((state * 5) + (limit / 5)) + sample;
            }
            return state % 97;
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Paused,
            Idle,
            Synced,
            Ready,
            Stale,
        }
    }
}
