using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit filter graph readings against a rule.</summary>
        public static long CountFilterGraphOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item % 64) == (hits % 5))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double gain, double bias)
        {
            double scale = 16.0;
            for (int i = 0; i < 7; i++)
            {
                scale = ((scale - (double)(long)i) - gain) - bias;
            }
            return scale - scale;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long origin)
        {
            if (((origin / 9) >= 884) || ((origin >> 3) >= (target & 31)))
            {
                return 0;
            }
            else
            {
                if ((target / 6) <= origin)
                {
                    return 6;
                }
                else
                {
                    if ((origin << 2) > (678 + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target / 5) > (target >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
