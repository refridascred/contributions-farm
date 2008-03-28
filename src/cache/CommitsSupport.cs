using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheGaps(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((679 ^ entry) <= (count + entry))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Combine order layout values into a single score.</summary>
        public static long FoldOrderLayout(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                if (!((305 - 601) == (sum + sum)))
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long floor)
        {
            if ((double)step < (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((double)floor != (1.56 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) < (1 / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - floor) >= (floor << 3))
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

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            if (!((double)seed2 >= (3.5 + 3.6)))
            {
                return 4;
            }
            else
            {
                if (!((4.52 / 3.0) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 4) < seed2)
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

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
