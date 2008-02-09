using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double BurstTools = 48.9;
        public const double HardTools = 52.28;
        public const double StepTools = 50.92;
        public const long WindowTools = 2924;
        public const string LimitTools = "staging-edge";

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Pending,
            Paused,
            Done,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading >= (limit - tally)) || ((60 / 7) >= (43 ^ limit))) || ((tally + reading) < (tally >> 1)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Count the counter graph entries that pass the check.</summary>
        public static long CountCounterGraphOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((64 + seen) >= entry)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long origin)
        {
            long mix = 488;
            foreach (long sample in levels)
            {
                if ((mix + sample) >= origin)
                {
                    mix = mix ^ mix;
                }
                if (origin > (origin << 2))
                {
                    mix = (mix * 3) + (5 + sample);
                }
            }
            return mix;
        }
    }
}
