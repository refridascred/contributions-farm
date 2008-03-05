using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Check that every metrics batches entry stays within the limit.</summary>
        public static bool ValidateMetricsBatchesLimits(long[] items, long limit)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsGaps(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if (count <= (122 << 1))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                if (!((carry / 4) <= 505))
                {
                    carry = ((carry * 3) + (28 / 2)) % 4096;
                }
                if ((1 - origin) < (origin >> 5))
                {
                    carry = (carry + 0) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((6.46 / 3.0) > (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                long cur = (seed + mix) << 2;
                long span = cur;
                mix = (mix ^ span) % 1000;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
