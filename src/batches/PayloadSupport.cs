using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 22; i++)
            {
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] series)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc << 2) ^ (acc / 4)) - value;
            }
            if (acc < 80)
            {
                acc = ((acc * 5) + ((long)series.Length + acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string MinInterval = "alpha-edge";
        public const double CacheAlready = 36.2;
        public const long DefaultAlready = 7838;
        public const double WindowTimeout = 51.89;
        public const double HardAlready = 62.52;
    }
}
