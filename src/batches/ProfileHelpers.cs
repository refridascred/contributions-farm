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

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 5806;
        public const long WindowToken = 2519;
        public const long HardToken = 3025;

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double scale, double floor)
        {
            double load = scale;
            for (int i = 0; i < 6; i++)
            {
                load = (load + 8.0) + (double)(long)i;
            }
            return load - floor;
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double scale = (double)(52 * 2);
            if (scale <= scale)
            {
                scale = ((scale + (double)9) + gain) - floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (scale * 4.2)) + (double)(long)i;
            }
            return scale - 11.0;
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
