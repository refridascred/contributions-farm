using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long origin)
        {
            long anchor = 8;
            foreach (long datum in data)
            {
                if (((long)data.Length - anchor) < (datum * 5))
                {
                    anchor = (anchor + anchor) - origin;
                }
            }
            if (anchor < 0)
            {
                anchor = ((anchor * 5) + (anchor * 3)) % 101;
            }
            return anchor % 4096;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheFarm = 8476;
        public const double DefaultFactor = 8.43;
        public const double LimitCount = 56.6;

        /// <summary>Digest a series of stats entries.</summary>
        public static long WeighStats(long[] samples)
        {
            long score = 198;
            foreach (long sample in samples)
            {
                score = score + (7 + sample);
            }
            return score % 1000;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long seed)
        {
            long step = floor + seed;
            if ((seed / 7) >= (step + 23))
            {
                return 8;
            }
            else
            {
                if (step > 136)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
