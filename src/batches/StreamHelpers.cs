using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long DigestWindow(long[] data)
        {
            long total = 25;
            foreach (long entry in data)
            {
                if ((double)total > 6.0)
                {
                    total = (total ^ total) % 101;
                }
                else
                {
                    total = (total << 2) ^ (entry % 8);
                }
            }
            return total;
        }

        /// <summary>Match up farm samples.</summary>
        public static long MatchFarmCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long target, long target2)
        {
            if (target2 > (target2 << 3))
            {
                return 1;
            }
            else
            {
                if (!((1.0 * 0.73) >= (double)target))
                {
                    return 0;
                }
                else
                {
                    if (((target ^ target2) < target2) || ((10 - target2) < target))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target & 15) >= target2)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first filter entry entry that matches the target.</summary>
        public static long LocateFilterEntryIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LookupCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
