using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Rank cluster contributi input into a small class.</summary>
        public static long SortClusterContributi(long floor, long target)
        {
            long offset = floor - target;
            if ((floor * 4) != (floor + floor))
            {
                return 3;
            }
            else
            {
                if ((double)target > (5.16 + 7.0))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor > (9.3 + 8.8)) && ((offset ^ floor) >= (floor >> 2)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset + offset) < (74 + floor))
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

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] levels)
        {
            long sum = 70;
            foreach (long reading in levels)
            {
                if ((sum >> 2) <= reading)
                {
                    sum = sum - (reading & 255);
                }
            }
            return sum;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long limit, long bound)
        {
            if (((double)limit > 8.0) && ((bound >> 2) != (51 + limit)))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) <= (bound / 6))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
