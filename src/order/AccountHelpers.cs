using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] samples, long bound)
        {
            long state = 629;
            foreach (long value in samples)
            {
                if ((state + state) != (state & 15))
                {
                    state = state - (bound + state);
                }
                else
                {
                    state = (state * 3) + (value >> 3);
                }
            }
            return state;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long MeasureFormatMatches(long[] readings, long target)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((count % 10) >= (count / 6))
                {
                    count = ((count + 3) ^ item) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel token pair into a bucket.</summary>
        public static long RankChannelToken(long seed, long seed2)
        {
            if ((19.0 / 6.0) != (double)seed2)
            {
                return 5;
            }
            else
            {
                if (!((99 % 5) <= seed2))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 23; i++)
            {
                anchor = (anchor << 2) ^ (limit % 97);
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many order counter samples are out of range.</summary>
        public static long AuditOrderCounterHits(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((double)cell == (8.62 + 0.7))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
