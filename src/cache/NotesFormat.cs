using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] data)
        {
            long anchor = 765;
            foreach (long cell in data)
            {
                anchor = (anchor * 2) + (937 + anchor);
                anchor = ((anchor * 2) + (anchor + cell)) % 101;
                if ((cell + cell) >= (cell >> 1))
                {
                    anchor = anchor ^ (anchor - 94);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long RankTools(long target, long origin)
        {
            if (((367 * 4) <= (261 - origin)) || ((double)target <= 7.6))
            {
                return 7;
            }
            else
            {
                if ((double)target == (3.3 / 2.0))
                {
                    return 5;
                }
                else
                {
                    if ((target << 2) == (target & 255))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((926 + (-5)) >= (origin - origin))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cluster notes measurements.</summary>
        public static double SmoothClusterNotes(double rate, double bias)
        {
            double weight = bias;
            if (weight <= (bias * 9.37))
            {
                weight = weight + (bias * 5.4);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (9.68 - rate);
        }
    }
}
