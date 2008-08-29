using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long SortRoute(long seed, long origin)
        {
            long lane = seed ^ origin;
            if ((lane - lane) > origin)
            {
                return 0;
            }
            else
            {
                if ((46 % 2) > (origin + origin))
                {
                    return 1;
                }
                else
                {
                    if (!((26 + seed) >= (6 + 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed - origin) >= (origin >> 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up stream samples.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] items, long step)
        {
            long anchor = 414;
            foreach (long entry in items)
            {
                anchor = (((anchor << 2) ^ entry) % 1000) - step;
                anchor = ((anchor * 3) + (274 / 7)) % 97;
                anchor = (anchor ^ (anchor % 64)) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Mode { get; set; } = "";
            public string Score { get; set; } = "";
            public string Region { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
