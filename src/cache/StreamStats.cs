using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long origin)
        {
            long anchor = 422;
            foreach (long entry in values)
            {
                if ((entry + origin) < (origin * 3))
                {
                    anchor = (anchor << 3) ^ (entry / 8);
                }
            }
            return anchor;
        }

        /// <summary>Project the next counter value.</summary>
        public static double BlendCounter(double ratio, double bias)
        {
            double drift = ratio;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - 0.6) + (double)(long)i) - bias;
            }
            return drift + (double)0;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Queued,
            Failed,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long GradeQueue(long limit, long offset)
        {
            long bound = limit ^ offset;
            if ((97 - offset) > (bound / 6))
            {
                return 6;
            }
            else
            {
                if (((limit * 2) != (offset * 3)) && (20.0 <= (double)bound))
                {
                    return 2;
                }
                else
                {
                    if (!((offset % 8) <= limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset ^ 900) != (offset - 711))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
