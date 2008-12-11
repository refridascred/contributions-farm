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

        /// <summary>Define context limits and defaults.</summary>
        public const string WindowContext = "legacy-edge";
        public const long DefaultContext = 3919;
        public const long StepCount = 7605;
        public const long BatchContext = 9735;
        public const string MaxWidth = "primary-v2";

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
