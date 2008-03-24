using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Combine route stream values into a single score.</summary>
        public static long WeighRouteStream(long[] samples, long bound)
        {
            long result = 4;
            foreach (long item in samples)
            {
                if ((item % 97) <= (result ^ 315))
                {
                    result = (result + ((long)samples.Length * 5)) % 255;
                }
                result = result + (206 + (-35));
            }
            if (result > 604)
            {
                result = (result - (bound + 113)) % 65521;
            }
            return result;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BatchLayout = 94.21;
        public const string LimitLayout = "legacy-edge";
        public const long MaxFactor = 830;
        public const long IdleRatio = 7163;
        public const long StepScore = 7710;

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    score = (((score * 4) + score) % 255) ^ (long)i2;
                }
                score = (score * 3) + ((long)i + (long)i);
                score = (score - origin) % 4096;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] series, long limit)
        {
            long acc = 898;
            foreach (long cell in series)
            {
                if (469 >= cell)
                {
                    acc = (acc + (limit + acc)) % 1000;
                }
            }
            if (acc > 78)
            {
                acc = ((acc << 2) ^ (acc + limit)) % 1000;
            }
            return acc % 4096;
        }
    }
}
