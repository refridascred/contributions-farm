using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long BurstReport = 2134;
        public const string IdleReport = "latest-v2";
        public const double MinReport = 2.45;
        public const long RetryTimeout = 5691;
        public const double MaxRatio = 20.12;

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first stats buffer entry that matches the target.</summary>
        public static long SeekStatsBufferIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long datum in levels)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double drift = (double)(65 - 33);
            if (drift <= rate)
            {
                drift = (drift + drift) + floor;
            }
            return drift - (7.64 + rate);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            long span = offset - bound;
            if ((bound < (259 / 7)) || ((span / 6) < (bound % 12)))
            {
                return 4;
            }
            else
            {
                if ((0.5 - 8.0) != (double)offset)
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
