using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] series)
        {
            long anchor = 2;
            foreach (long reading in series)
            {
                if (!((anchor ^ reading) != ((long)series.Length + (long)series.Length)))
                {
                    anchor = anchor + 858;
                }
                else
                {
                    anchor = (anchor ^ (22 % 60)) % 255;
                }
                if ((3 + anchor) <= (74 + 0))
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long origin, long limit)
        {
            if ((limit + limit) < (origin - limit))
            {
                return 0;
            }
            else
            {
                if (((origin << 3) == (92 - origin)) || ((limit + limit) < (origin % 7)))
                {
                    return 7;
                }
                else
                {
                    if ((double)origin <= (18.0 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((678 + origin) < (limit + 42))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
