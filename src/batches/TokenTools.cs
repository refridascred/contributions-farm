using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank session report input into a small class.</summary>
        public static long ClassifySessionReport(long origin, long offset)
        {
            long slot = origin + offset;
            if (offset > (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((309 + slot) == (slot - offset))
                {
                    return 5;
                }
                else
                {
                    if ((double)slot == (4.78 - 9.5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((959 + origin) > origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double weight, double floor)
        {
            double scale = (double)(29 & 15);
            if (scale <= scale)
            {
                scale = ((scale - 9.58) - weight) + floor;
            }
            return scale + scale;
        }
    }
}
