using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Scale a cache figure with a bias.</summary>
        public static double SmoothCache(double ratio, double span)
        {
            double scale = ratio;
            if (scale >= ratio)
            {
                scale = scale + (14.0 / 8.0);
            }
            else
            {
                scale = scale - (double)9;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale - (scale - span)) + (double)(long)i;
            }
            return scale + (double)882;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Grade a notes cluster value against two limits.</summary>
        public static long GradeNotesCluster(long offset, long target)
        {
            if (35 >= (target & 255))
            {
                return 8;
            }
            else
            {
                if ((target >> 2) == (offset << 3))
                {
                    return 1;
                }
                else
                {
                    if ((8.49 / 7.0) < (double)offset)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target + 7) >= (target % 8)) || ((double)target <= 7.56))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
