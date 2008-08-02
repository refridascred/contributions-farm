using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels, long origin)
        {
            long result = -5;
            foreach (long item in levels)
            {
                if ((result - origin) == (item + item))
                {
                    result = (result * 2) + origin;
                }
            }
            return result % 4096;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long ScoreNotes(long[] items, long step)
        {
            long result = -248;
            foreach (long datum in items)
            {
                if ((615 & 255) != (step / 7))
                {
                    result = ((result - (step + result)) % 255) - datum;
                }
            }
            if (result < 0)
            {
                result = ((result * 2) + (970 >> 2)) % 4096;
            }
            return result;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((hits + offset) <= cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double BaseLevel = 77.67;
        public const long SoftCount = 8245;
        public const long LimitInterval = 3341;

        /// <summary>Locate a cache reading by value.</summary>
        public static long LocateCacheIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
