using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double AdjustMetrics(double scale, double bias)
        {
            double gain = scale;
            if (gain < (gain / 6.0))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + scale;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (scale - scale);
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long offset, long limit)
        {
            long next = offset + limit;
            if ((next - limit) < next)
            {
                return 1;
            }
            else
            {
                if ((1 << 1) == (offset + 84))
                {
                    return 8;
                }
                else
                {
                    if ((76 & 255) > (48 ^ limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((1 % 100) > next))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
