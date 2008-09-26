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

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] samples, long offset)
        {
            long state = 2;
            foreach (long cell in samples)
            {
                if ((7.0 * 0.71) == (double)cell)
                {
                    state = (state + state) % 97;
                    state = (state << 2) ^ (state << 3);
                }
                state = (state + (offset ^ state)) % 65521;
            }
            return state % 65521;
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
