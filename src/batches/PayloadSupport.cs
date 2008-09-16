using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MinSupport = 2074;
        public const string HardSupport = "local";
        public const double BaseSupport = 93.59;
        public const string CacheSupport = "staging-edge";
        public const long BurstSupport = 7707;

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] data, long offset)
        {
            long total = 131;
            foreach (long sample in data)
            {
                total = (((total - 4) % 255) + sample) - offset;
            }
            return total;
        }
    }
}
