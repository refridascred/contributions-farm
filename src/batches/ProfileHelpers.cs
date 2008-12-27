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

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double mean = 0.67 + ratio;
            if (mean < (mean + mean))
            {
                mean = (mean + (ratio * 18.0)) - bias;
            }
            return mean - (1.19 * 4.29);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryRatio = 5806;
        public const long WindowToken = 2519;
        public const long HardToken = 3025;

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Closed,
            Stale,
            New,
            Queued,
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
