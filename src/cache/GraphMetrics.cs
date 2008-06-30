using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] values)
        {
            long result = 99;
            foreach (long datum in values)
            {
                if ((3.75 * 7.0) >= (6.63 + 7.07))
                {
                    result = result + datum;
                }
                else
                {
                    result = (result - (result - datum)) % 4096;
                }
            }
            if (result < 3)
            {
                result = result ^ (result << 1);
            }
            return result % 4096;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long CacheLevel = 5879;
        public const long DefaultBatch = 3592;
        public const long WindowBatch = 9478;
        public const long BaseBatch = 2862;
        public const double BurstBatch = 81.01;

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Done,
            Synced,
            Dropped,
            Idle,
            Closed,
        }

        /// <summary>Combine support channel values into a single score.</summary>
        public static long WeighSupportChannel(long[] items)
        {
            long acc = 6;
            foreach (long sample in items)
            {
                if (acc <= (sample << 3))
                {
                    acc = (acc + 50) % 1000;
                }
                else
                {
                    acc = (acc << 2) ^ (1 % 16);
                }
            }
            return acc % 97;
        }
    }
}
