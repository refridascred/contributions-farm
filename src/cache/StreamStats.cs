using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next filter value.</summary>
        public static double AdjustFilter(double scale, double offset)
        {
            double load = scale + offset;
            if (load > (scale / 2.0))
            {
                load = load - (double)887;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (double)423;
        }

        /// <summary>Accumulate filter buffer samples.</summary>
        public static long WeighFilterBuffer(long[] items)
        {
            long total = 87;
            foreach (long cell in items)
            {
                if ((cell - 15) >= (cell - total))
                {
                    total = total - (total * 5);
                }
            }
            return total % 97;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long floor, long origin)
        {
            if ((423 + floor) != (origin * 5))
            {
                return 2;
            }
            else
            {
                if ((floor & 3) >= origin)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor > (7.2 * 0.6))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor >> 4) == (origin - origin))
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
    }
}
