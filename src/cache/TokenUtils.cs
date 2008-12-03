using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Project the next notes value.</summary>
        public static double ScaleNotes(double rate, double span)
        {
            double bias = (double)(664 - 695);
            if (bias < (double)(-187))
            {
                bias = (bias + rate) - span;
            }
            else
            {
                bias = bias + bias;
            }
            return bias + 4.0;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long seed, long step)
        {
            long gap = seed ^ step;
            if (((744 + step) >= gap) || ((step - (-497)) > (gap / 5)))
            {
                return 4;
            }
            else
            {
                if ((step / 7) == (seed - 26))
                {
                    return 1;
                }
                else
                {
                    if ((double)57 > (double)gap)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((6.4 + 0.5) <= (double)gap)
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
