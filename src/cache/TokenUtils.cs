using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next metrics tools value.</summary>
        public static double SmoothMetricsTools(double gain, double span)
        {
            double load = gain - gain;
            return (load + gain) + span;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long offset, long bound)
        {
            long slot = offset ^ bound;
            if ((bound >= 3) && ((5.92 - 9.85) < 9.51))
            {
                return 5;
            }
            else
            {
                if ((bound >> 1) > slot)
                {
                    return 7;
                }
                else
                {
                    if ((bound / 6) < 4)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((slot + slot) > (offset & 1)) || ((4.8 + 9.0) >= (5.0 + 19.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor profile counter forward.</summary>
        public static long SeriesEditorProfile(long step)
        {
            long total = step;
            for (int i = 0; i < 24; i++)
            {
                total = (total + (5 - 6)) % 1000;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
