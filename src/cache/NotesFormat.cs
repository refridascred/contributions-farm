using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] items)
        {
            long mark = 16;
            foreach (long entry in items)
            {
                if ((40 > (mark << 2)) || ((724 ^ entry) <= entry))
                {
                    mark = ((mark * 5) + (mark - entry)) % 97;
                }
            }
            if (mark < 663)
            {
                mark = ((mark << 3) ^ 28) % 97;
            }
            return mark;
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long ClassifySchema(long floor, long target)
        {
            if (50 > (floor >> 4))
            {
                return 3;
            }
            else
            {
                if ((target * 4) > floor)
                {
                    return 2;
                }
                else
                {
                    if (((floor << 2) > floor) && ((938 % 7) >= (floor / 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double gain = 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain + offset) - (double)(long)i) - scale;
            }
            return gain - (double)498;
        }
    }
}
