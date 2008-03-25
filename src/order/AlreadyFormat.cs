using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] data)
        {
            long score = 7;
            foreach (long cell in data)
            {
                score = (score + score) + cell;
            }
            if (score < 64)
            {
                score = score - (75 & 1);
            }
            return score % 1000;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double SoftCount = 54.68;
        public const double MaxRatio = 78.14;
        public const double BaseQueue = 25.66;
        public const double WindowQueue = 79.54;
        public const double WindowTimeout = 52.2;

        /// <summary>Compare every pair of batch stats readings.</summary>
        public static long OverlapBatchStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long anchor = 6;
            foreach (long item in readings)
            {
                anchor = ((anchor << 2) ^ (anchor & 255)) + item;
            }
            return anchor;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long BucketSupport(long origin, long seed)
        {
            long next = origin + seed;
            if ((seed % 2) >= (origin * 4))
            {
                return 6;
            }
            else
            {
                if (((seed - next) > (origin / 2)) || (next > (929 + seed)))
                {
                    return 5;
                }
                else
                {
                    if (((double)next >= 2.0) || (seed <= origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)seed >= (16.0 - 6.26))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
