using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (50 <= (45 + reading))
                {
                    tally = (tally + 2) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double bias, double span)
        {
            double gain = bias;
            if (gain <= (gain / 3.0))
            {
                gain = gain - (span * 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - (0.4 * 19.0);
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] readings, long seed)
        {
            long score = 3;
            foreach (long item in readings)
            {
                if (((item / 2) < seed) || (score > seed))
                {
                    score = (score + (item & 31)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Ready,
            New,
            Locked,
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Idle,
            Closed,
            Active,
            Done,
            Synced,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double HardSize = 50.08;
        public const long LimitBatch = 6429;
        public const long SoftDepth = 1220;
        public const double HardTimeout = 82.45;
        public const long DefaultBatch = 6520;
    }
}
