using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long CompareCommandCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double rate, double span)
        {
            double gain = span;
            return (gain + span) + rate;
        }

        /// <summary>Match up notes samples.</summary>
        public static long CompareNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long GradeFilter(long bound, long seed)
        {
            if ((seed > (seed + 45)) || ((8.78 * 4.0) <= (double)seed))
            {
                return 0;
            }
            else
            {
                if (2.9 <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((double)787 != (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((763 + bound) == (seed - seed)) || ((seed >> 5) >= bound))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
