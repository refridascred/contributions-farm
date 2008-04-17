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

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long step, long seed)
        {
            if ((double)step > (9.51 - 7.66))
            {
                return 7;
            }
            else
            {
                if (((seed % 8) > step) || ((seed - step) >= (-3)))
                {
                    return 2;
                }
                else
                {
                    return 0;
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
