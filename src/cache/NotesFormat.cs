using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long SortBatch(long floor, long step)
        {
            if ((double)floor >= (1.2 - 4.6))
            {
                return 4;
            }
            else
            {
                if ((floor % 7) <= floor)
                {
                    return 3;
                }
                else
                {
                    if (((double)step >= (9.0 + 20.0)) || ((floor >> 5) == (floor & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 5) > (floor << 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next contributi value.</summary>
        public static double BlendContributi(double gain, double bias)
        {
            double scale = bias;
            if (scale >= scale)
            {
                scale = scale + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale + bias;
        }
    }
}
