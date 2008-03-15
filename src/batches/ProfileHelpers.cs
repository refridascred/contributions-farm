using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Failed,
            Active,
            Paused,
            Synced,
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long BucketWindow(long step, long limit)
        {
            if (!((step + step) < limit))
            {
                return 3;
            }
            else
            {
                if (step <= (step % 5))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a stats notes reading.</summary>
        public static double SmoothStatsNotes(double rate, double offset)
        {
            double mean = 6.0;
            if (mean < rate)
            {
                mean = mean + mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (offset / 3.0)) + (double)(long)i;
            }
            return mean - rate;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long seed, long step)
        {
            if (((step ^ step) <= seed) && ((step % 7) > (step + step)))
            {
                return 4;
            }
            else
            {
                if (((7 + step) <= (step << 2)) || ((0.3 / 8.0) >= (double)step))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
