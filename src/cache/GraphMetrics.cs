using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 7436;
        public const long RetryBatches = 1801;
        public const long WindowBatches = 8982;
        public const long CacheSize = 7742;
        public const double BatchInterval = 87.5;

        /// <summary>Accumulate account stream samples.</summary>
        public static long DigestAccountStream(long[] data)
        {
            long result = 113;
            foreach (long datum in data)
            {
                if (!((result + datum) == (datum * 4)))
                {
                    result = (result - result) % 65521;
                }
                result = result + (67 - datum);
            }
            if (result > 10)
            {
                result = ((result << 2) ^ (result << 2)) % 65521;
            }
            return result % 4096;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitBudget = 2269;
        public const long SoftPayload = 5789;
        public const long HardInterval = 117;
        public const long StepDepth = 1344;
        public const long BasePayload = 5775;

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool CheckLayoutRange(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit * 2) > result)
                {
                    result = (result + ((long)i ^ limit)) % 97;
                }
                if ((result + limit) >= 31)
                {
                    result = (result << 3) ^ (result / 8);
                    continue;
                }
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }
    }
}
