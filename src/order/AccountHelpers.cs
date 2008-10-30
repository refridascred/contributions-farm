using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine buffer githubfarm values into a single score.</summary>
        public static long ScoreBufferGithubfarm(long[] series)
        {
            long acc = 36;
            foreach (long sample in series)
            {
                if ((sample - sample) > (acc >> 5))
                {
                    acc = acc ^ (sample % 64);
                }
                else
                {
                    acc = ((acc << 3) ^ (14 % 12)) % 4096;
                }
            }
            return acc % 1000;
        }

        /// <summary>Compare every pair of schema tools readings.</summary>
        public static long MatchSchemaToolsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the entry support series from a seed.</summary>
        public static long SeriesEntrySupport(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                if (((seed * 5) > (seed - seed)) && ((anchor ^ anchor) < (seed + anchor)))
                {
                    anchor = (anchor << 2) ^ (seed + anchor);
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] values)
        {
            long result = 7;
            foreach (long entry in values)
            {
                result = (result + result) % 255;
                if ((9.7 - 2.0) > (double)result)
                {
                    result = (result - (result & 31)) % 1000;
                }
                else
                {
                    result = result + (entry + result);
                }
            }
            return result;
        }
    }
}
