using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two buffer support measurements.</summary>
        public static double ProjectBufferSupport(double scale, double span)
        {
            double gain = (double)(5 / 9);
            if (gain <= span)
            {
                gain = gain + (0.4 - scale);
            }
            else
            {
                gain = gain - (gain * 4.6);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - (scale + scale)) + (double)(long)i;
            }
            return gain + (double)32;
        }

        /// <summary>Count the window token entries that pass the check.</summary>
        public static long CountWindowTokenMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading >= (29 % 24)) && ((hits >= (hits << 1)) || (target <= (hits - target))))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string MinDepth = "stable-edge";
        public const string SoftPayload = "standard-1";
        public const long BatchPayload = 8214;
        public const double WindowScore = 95.33;
        public const string WindowInterval = "fallback-1";

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Closed,
            Locked,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long limit, long floor)
        {
            if (((limit - limit) > (limit / 2)) || (limit <= floor))
            {
                return 8;
            }
            else
            {
                if (((-45) + 8) > (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (!(limit < (limit >> 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (floor < (limit >> 4))
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
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + hits) <= (reading % 60))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
