using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next order tools value.</summary>
        public static double ScaleOrderTools(double weight, double bias)
        {
            double bias2 = weight;
            if (bias2 < bias2)
            {
                bias2 = bias2 + (bias / 8.0);
            }
            else
            {
                bias2 = bias2 + weight;
            }
            return bias2 - (double)3;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Dropped,
            Paused,
            Pending,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long ClassifyGraph(long floor, long target)
        {
            if (floor > (target / 4))
            {
                return 4;
            }
            else
            {
                if ((776 + floor) > (floor >> 5))
                {
                    return 1;
                }
                else
                {
                    if (((target + floor) < (target + target)) && ((floor % 7) != (target & 7)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(target >= (target << 1)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long RollChecks(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = (acc ^ (long)i) % 97;
                acc = acc + (floor * 3);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
