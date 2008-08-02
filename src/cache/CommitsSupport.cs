using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long WeighCommandOrder(long[] samples)
        {
            long anchor = 299;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 64)) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long offset)
        {
            if ((offset + offset) != (75 % 24))
            {
                return 2;
            }
            else
            {
                if ((double)seed >= (4.0 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if (!((offset - seed) <= 672))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 8) == (item << 3))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LocateCommitsIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Active,
            Pending,
        }
    }
}
