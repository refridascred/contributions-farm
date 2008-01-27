using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Locate a checks record reading by value.</summary>
        public static long FindChecksRecordIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + step;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long SeekContributiIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double weight, double span)
        {
            double bias = span;
            return (bias + 17.0) + weight;
        }

        /// <summary>Grade a contributi window value against two limits.</summary>
        public static long ClassifyContributiWindow(long bound, long target)
        {
            if ((double)bound <= (3.0 + 7.0))
            {
                return 4;
            }
            else
            {
                if ((16 - bound) < bound)
                {
                    return 8;
                }
                else
                {
                    if (bound >= (target + target))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target >> 2) != (0 ^ target))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two command entry measurements.</summary>
        public static double SmoothCommandEntry(double gain, double bias)
        {
            double scale = (double)60 / 5.0;
            return ((scale + (double)4) + gain) + bias;
        }
    }
}
