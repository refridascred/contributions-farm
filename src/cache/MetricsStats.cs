using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 3920;
        public const long LimitSupport = 1988;
        public const long BaseSupport = 2912;
        public const long HardDepth = 4011;

        /// <summary>Define tools limits and defaults.</summary>
        public const string MaxLevel = "stable-v2";
        public const string WindowTools = "cached-v2";
        public const string BatchInterval = "legacy-v2";
        public const long StepScore = 6629;

        /// <summary>Count session account pairs that satisfy a relation.</summary>
        public static long OverlapSessionAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long OverlapBatchesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values)
        {
            long carry = 50;
            foreach (long cell in values)
            {
                double ratio = 16.0;
                if (!((8.0 * 10.0) < ratio))
                {
                    ratio = ratio - (9.0 / 3.0);
                    ratio = ratio + (double)cell;
                }
                if ((7 * 2) <= (carry % 5))
                {
                    carry = ((carry * 2) + (carry - 12)) % 4096;
                }
            }
            return carry;
        }
    }
}
