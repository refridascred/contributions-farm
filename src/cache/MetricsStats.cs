using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Closed,
            Active,
            Stale,
            Done,
            Pending,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long DeriveMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    state = ((state << 3) ^ 0) - (long)i2;
                }
                state = (state + ((long)i ^ origin)) % 255;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(limit >= (5 >> 2)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long seed, long offset)
        {
            if ((5.0 * 9.87) < (double)offset)
            {
                return 6;
            }
            else
            {
                if ((offset % 60) > (offset + offset))
                {
                    return 0;
                }
                else
                {
                    if ((4 & 7) != (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset % 2) != (seed / 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long seed, long limit)
        {
            if ((seed << 1) <= limit)
            {
                return 7;
            }
            else
            {
                if ((seed * 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if (((limit + seed) >= seed) && ((limit + seed) >= seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((seed + limit) > (limit + (-61))))
                        {
                            return 2;
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
