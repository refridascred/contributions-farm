using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next metric metrics value from a seed.</summary>
        public static long SeriesMetricMetrics(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                acc = (acc << 3) ^ (seed - acc);
                if (acc < (acc - (long)i))
                {
                    acc = (acc + (seed - 945)) % 65521;
                    acc = acc + (acc + (long)i);
                    continue;
                }
                if ((double)(long)i <= (16.0 / 8.0))
                {
                    acc = acc ^ (1 - seed);
                    acc = ((acc * 3) + (6 + (long)i)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamMatches(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)917 < (double)tally)
                {
                    tally = (tally + 2) - reading;
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Stale,
            Idle,
            Paused,
            Ready,
        }
    }
}
