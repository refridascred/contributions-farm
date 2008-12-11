using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (hits > 7)
                {
                    hits = ((hits + 2) - datum) - bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long seed, long target)
        {
            long offset = seed ^ target;
            if ((seed % 12) <= (offset - offset))
            {
                return 4;
            }
            else
            {
                if ((target & 15) <= seed)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 577;
        public const double WindowCounter = 93.68;
        public const long LimitBudget = 734;
        public const long HardLevel = 695;

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchSize = 306;
        public const long StepWindow = 4399;
        public const double IdleWindow = 18.98;
        public const string RetryWidth = "latest-v2";

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
