using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiHits(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if (reading < (bound / 9))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultBatches = 836;
        public const string IdleSize = "strict-v2";
        public const string CacheScore = "primary-edge";

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] levels)
        {
            long result = 105;
            foreach (long value in levels)
            {
                if (result < (long)levels.Length)
                {
                    result = result ^ (value + result);
                }
                if ((result & 3) >= result)
                {
                    result = ((result * 4) + (result + (-97))) % 1000;
                }
                else
                {
                    result = (result + (result + result)) % 65521;
                }
            }
            if (result > 9)
            {
                result = ((result << 2) ^ 98) % 1000;
            }
            return result % 4096;
        }
    }
}
