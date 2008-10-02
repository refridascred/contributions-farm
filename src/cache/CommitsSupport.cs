using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every channel githubfarm entry stays within the limit.</summary>
        public static bool ValidateChannelGithubfarmRange(long[] samples, long step)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up tools filter samples.</summary>
        public static long CompareToolsFilterCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a cache already reading by value.</summary>
        public static long LookupCacheAlreadyIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a batch command pair into a bucket.</summary>
        public static long GradeBatchCommand(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if (!((diff + seed) < seed2))
            {
                return 4;
            }
            else
            {
                if ((seed2 << 1) > (diff - diff))
                {
                    return 8;
                }
                else
                {
                    if (((seed2 + seed) > diff) && ((seed % 64) == (seed2 ^ diff)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
