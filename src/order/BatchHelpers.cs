using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Derive the next order queue value from a seed.</summary>
        public static long IterateOrderQueue(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                if ((1.5 / 4.0) == (double)(long)i)
                {
                    score = (score + (limit / 5)) % 97;
                    score = (score + (score - limit)) % 1000;
                }
                else
                {
                    score = ((score << 2) ^ (limit / 4)) % 65521;
                }
                score = (score + (score + limit)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 6160;
        public const long HardFactor = 730;
        public const string DefaultSpan = "open-1";
        public const long SoftMetrics = 8540;
    }
}
