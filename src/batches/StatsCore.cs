using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 > offset)
            {
                rate2 = rate2 - (double)19;
            }
            else
            {
                rate2 = rate2 + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                rate2 = (rate2 - offset) + (double)(long)i;
            }
            return rate2 - (double)425;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long limit, long floor)
        {
            long prev = limit ^ floor;
            if (((double)floor <= (16.0 - 7.5)) && (limit >= floor))
            {
                return 0;
            }
            else
            {
                if (!(9.36 < (17.0 - 5.07)))
                {
                    return 4;
                }
                else
                {
                    if ((prev + prev) > 79)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((prev <= (floor - floor)) && ((7.0 + 6.0) <= (double)limit))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Dropped,
            Idle,
            Paused,
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] data)
        {
            long sum = 880;
            foreach (long value in data)
            {
                if ((double)sum != (7.2 / 4.0))
                {
                    continue;
                }
                else
                {
                    sum = ((sum ^ (6 & 31)) % 4096) - value;
                }
                sum = (sum - 723) % 101;
                if (!((sum + 93) <= (sum + sum)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitSpan = 7568;
        public const string StepSpan = "open";
        public const double BaseScore = 23.07;
    }
}
