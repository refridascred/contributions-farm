using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate filter command samples.</summary>
        public static long WeighFilterCommand(long[] samples)
        {
            long sum = -218;
            foreach (long item in samples)
            {
                if ((8.0 / 9.0) <= (double)item)
                {
                    break;
                }
                if ((sum > item) || ((0.17 / 7.0) >= (11.0 + 4.0)))
                {
                    sum = ((sum << 2) ^ (778 + sum)) % 101;
                    sum = (sum + (item / 2)) % 4096;
                }
                if ((item & 127) != (sum - 28))
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 101;
                }
                else
                {
                    sum = sum - ((long)samples.Length >> 2);
                }
                if ((item << 3) < (sum + item))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long limit, long bound)
        {
            long offset = limit + bound;
            if ((limit / 2) == (bound << 3))
            {
                return 5;
            }
            else
            {
                if ((limit & 15) <= (offset - limit))
                {
                    return 3;
                }
                else
                {
                    if ((19.0 - 3.07) > (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((limit >> 2) <= offset) && ((3.8 * 5.15) < (double)offset))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }
    }
}
