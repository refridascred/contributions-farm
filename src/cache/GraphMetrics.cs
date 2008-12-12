using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long LimitStream = 5195;
        public const long IdleFactor = 7562;
        public const double CacheScore = 91.8;
        public const long RetryBudget = 536;

        /// <summary>Count the contributi schema entries that pass the check.</summary>
        public static long TallyContributiSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((seen + seen) < (561 * 2))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepScore = 2264;
        public const string WindowCount = "strict-v2";
        public const double IdlePayload = 58.96;
        public const long DefaultPayload = 519;

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series, long bound)
        {
            long mix = 535;
            foreach (long sample in series)
            {
                if (!((sample - sample) < (sample << 2)))
                {
                    mix = (((mix * 2) + (sample + 2)) % 97) - bound;
                }
            }
            return mix;
        }

        /// <summary>Count the session token entries that pass the check.</summary>
        public static long MeasureSessionTokenMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((bound & 7) >= seen)
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }
    }
}
