using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] items)
        {
            long score = -14;
            foreach (long datum in items)
            {
                if ((9.56 * 10.0) > (double)score)
                {
                    score = (score * 4) + datum;
                }
                if ((double)datum > 5.3)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long RankMetrics(long target, long origin)
        {
            if ((target % 8) > target)
            {
                return 2;
            }
            else
            {
                if (!((double)target >= (3.5 + 8.0)))
                {
                    return 5;
                }
                else
                {
                    if ((origin << 1) != (origin * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double floor)
        {
            double scale = (double)(509 * 5);
            if (scale > (scale / 8.0))
            {
                scale = (scale + 8.0) - floor;
            }
            return scale + rate;
        }

        /// <summary>Rank token order input into a small class.</summary>
        public static long ClassifyTokenOrder(long floor, long step)
        {
            if ((double)step > (double)floor)
            {
                return 5;
            }
            else
            {
                if (step <= (floor * 2))
                {
                    return 2;
                }
                else
                {
                    if ((double)step > 18.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long ScoreChannel(long[] levels, long floor)
        {
            long score = 852;
            foreach (long sample in levels)
            {
                score = (((score * 2) + (sample << 1)) % 4096) + floor;
            }
            return score % 1000;
        }

        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
