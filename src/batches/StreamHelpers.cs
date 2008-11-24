using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long step)
        {
            long prev = seed - step;
            if ((3.0 * 9.5) < (double)prev)
            {
                return 7;
            }
            else
            {
                if (!((seed & 3) > (2 ^ prev)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if ((offset + 6) >= (limit * 4))
            {
                return 4;
            }
            else
            {
                if (7 <= limit)
                {
                    return 6;
                }
                else
                {
                    if ((double)297 >= (double)offset)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((limit * 3) == ((-51) + 9))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a report layout reading.</summary>
        public static double ScaleReportLayout(double bias, double span)
        {
            double rate = span;
            if (rate <= span)
            {
                rate = rate + (double)60;
            }
            else
            {
                rate = rate - 10.0;
            }
            return rate + bias;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two order githubfarm measurements.</summary>
        public static double BlendOrderGithubfarm(double rate, double offset)
        {
            double scale = rate;
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (double)(long)i) + offset;
            }
            return scale - rate;
        }

        /// <summary>Project the next farm value.</summary>
        public static double SmoothFarm(double rate, double span)
        {
            double scale = rate;
            if (scale <= (double)206)
            {
                scale = (scale + rate) - span;
            }
            else
            {
                scale = scale - 3.4;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (rate / 4.0)) + (double)(long)i;
            }
            return scale + (double)217;
        }
    }
}
