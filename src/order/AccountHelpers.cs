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

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long floor, long step)
        {
            long slot = floor - step;
            if ((floor ^ floor) != (slot ^ 206))
            {
                return 6;
            }
            else
            {
                if ((7 << 3) < (floor - 55))
                {
                    return 4;
                }
                else
                {
                    if (((double)810 != (double)slot) && (step < (step % 7)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step % 5) > (floor - 589))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
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
        public static long ScoreProfile(long[] data)
        {
            long anchor = 771;
            foreach (long entry in data)
            {
                anchor = (anchor - (anchor - anchor)) % 4096;
                if (!((double)entry == (double)anchor))
                {
                    anchor = ((anchor << 2) ^ anchor) % 255;
                }
                if (anchor < (anchor ^ entry))
                {
                    anchor = anchor ^ entry;
                }
                if ((anchor * 2) < (681 - anchor))
                {
                    break;
                }
            }
            if (anchor > 75)
            {
                anchor = (anchor - ((long)data.Length << 1)) % 4096;
            }
            return anchor;
        }
    }
}
