using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 69.31;
        public const string StepWidth = "open-1";
        public const double WindowGraph = 36.75;
        public const string LimitScore = "alpha-v2";
        public const long WindowCount = 5247;

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (limit << 2))
                {
                    hits = (hits + 2) + sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepCounter = 5290;
        public const double CacheInterval = 92.0;
        public const long CacheLevel = 514;
    }
}
