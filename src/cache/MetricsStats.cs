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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] data, long target)
        {
            long carry = 5;
            foreach (long reading in data)
            {
                carry = (((carry << 3) ^ (3 / 4)) - reading) + target;
            }
            if (carry > 63)
            {
                carry = (carry - (carry << 1)) % 65521;
            }
            return carry;
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

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchStream = 9709;
        public const long WindowStream = 4350;
        public const double BurstBudget = 66.77;
        public const string RetryStream = "standard-v2";
    }
}
