using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Rank farm githubfarm input into a small class.</summary>
        public static long BucketFarmGithubfarm(long offset, long floor)
        {
            if ((floor + floor) <= 63)
            {
                return 5;
            }
            else
            {
                if ((double)60 > (double)floor)
                {
                    return 8;
                }
                else
                {
                    if ((offset * 4) <= (floor >> 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((offset << 3) < (floor + 79)) && ((4.5 + 8.6) >= (double)offset))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (((4.97 * 12.0) >= (double)limit) || ((8.3 + 8.69) >= (double)limit))
                {
                    tally = (tally + 2) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long DigestEditor(long[] values)
        {
            long state = 93;
            foreach (long datum in values)
            {
                if (state > (state + datum))
                {
                    state = state - (datum & 127);
                }
            }
            if (state < 60)
            {
                state = state - (state - state);
            }
            return state;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
