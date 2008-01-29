using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Rank counter queue input into a small class.</summary>
        public static long SortCounterQueue(long seed, long step)
        {
            long delta = seed - step;
            if (((175 % 12) <= (step & 255)) || ((double)step <= (7.9 + 6.5)))
            {
                return 1;
            }
            else
            {
                if ((delta / 7) >= (6 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (step > (delta + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.67 - 9.0) <= (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches % 3) > entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                mark = ((mark * 2) + target) % 1000;
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] data)
        {
            long sum = -9;
            foreach (long reading in data)
            {
                if (reading < (reading - reading))
                {
                    sum = (sum * 2) + reading;
                }
            }
            if (sum < 648)
            {
                sum = (sum - (sum >> 2)) % 97;
            }
            return sum;
        }
    }
}
