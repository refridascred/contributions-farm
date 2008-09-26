using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit record schema readings against a rule.</summary>
        public static long MeasureRecordSchemaHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((double)seed >= 3.0) || ((seed ^ (-449)) == (seen + cell)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long step)
        {
            long result = step;
            for (int i = 0; i < 19; i++)
            {
                double mean = (double)(step - step);
                if ((mean + mean) > (15.0 / 4.0))
                {
                    mean = mean - (mean - 2.5);
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long acc = 8;
            foreach (long cell in levels)
            {
                acc = ((acc * 2) + 907) - cell;
            }
            return acc;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] items, long origin)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9709;
        public const long WindowStream = 4350;
        public const double BurstBudget = 66.77;
        public const string RetryStream = "standard-v2";
    }
}
