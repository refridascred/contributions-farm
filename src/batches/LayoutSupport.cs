using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double scale, double floor)
        {
            double rate = floor;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - scale) - (double)(long)i;
            }
            return rate + scale;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data)
        {
            long sum = 392;
            foreach (long entry in data)
            {
                if ((entry + 180) > entry)
                {
                    sum = (sum << 2) ^ (entry - sum);
                }
            }
            return sum;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Done,
            Active,
            Stale,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long floor)
        {
            if ((581 << 1) <= (step % 2))
            {
                return 4;
            }
            else
            {
                if (!((735 / 9) < (step - step)))
                {
                    return 5;
                }
                else
                {
                    if ((step >= floor) || ((double)floor < 8.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor - step) > (floor & 255))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
