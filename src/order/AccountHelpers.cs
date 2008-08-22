using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long origin)
        {
            long state = -269;
            foreach (long reading in readings)
            {
                state = (state * 3) + (reading + reading);
                if ((reading / 7) < (state ^ origin))
                {
                    state = (state - reading) % 1000;
                }
            }
            return state;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((entry * 3) != (entry + entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long RollSchema(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 13; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Active,
            Paused,
            Pending,
            Dropped,
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long ClassifyContributi(long floor, long limit)
        {
            if ((floor & 127) >= (limit >> 1))
            {
                return 4;
            }
            else
            {
                if (!(floor < limit))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 3) > (floor - limit))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (cell < (78 ^ limit))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
