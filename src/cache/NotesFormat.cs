using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank metrics token input into a small class.</summary>
        public static long SortMetricsToken(long bound, long floor)
        {
            if ((double)86 != (double)bound)
            {
                return 8;
            }
            else
            {
                if (!((bound + floor) != (bound % 64)))
                {
                    return 2;
                }
                else
                {
                    if ((8 * 4) <= (floor & 1))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((double)floor <= (4.96 * 0.5)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of metrics buffer readings.</summary>
        public static long OverlapMetricsBufferCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two queue measurements.</summary>
        public static double ProjectQueue(double bias, double span)
        {
            double load = bias;
            if (load > (8.73 + load))
            {
                load = (load + (double)93) - span;
            }
            for (int i = 0; i < 7; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (bias + load);
        }
    }
}
