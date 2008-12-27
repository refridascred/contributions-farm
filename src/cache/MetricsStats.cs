using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Compare every pair of record channel readings.</summary>
        public static long CompareRecordChannelCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long DeriveStats(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 20; i++)
            {
                mix = mix + mix;
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long target)
        {
            long score = 3;
            foreach (long reading in data)
            {
                score = (((score << 2) ^ 1) ^ reading) + target;
            }
            return score;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheFilter = "alpha-1";
        public const double SoftFilter = 58.07;
        public const long IdleFactor = 8324;
        public const string MaxCount = "standard-1";
        public const double BaseSize = 0.97;
    }
}
