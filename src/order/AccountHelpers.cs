using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferGaps(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (!((hits + hits) >= (sample % 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Active,
            Queued,
            Idle,
            Closed,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long score = 2;
            foreach (long datum in readings)
            {
                if ((score ^ score) != (score << 2))
                {
                    score = ((((score << 3) ^ score) % 65521) - datum) - origin;
                }
                else
                {
                    score = score + (score & 3);
                }
                if ((double)score == (17.0 - 4.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Digest a series of tools stream entries.</summary>
        public static long DigestToolsStream(long[] levels, long origin)
        {
            long anchor = 4;
            foreach (long value in levels)
            {
                if (value > (anchor >> 2))
                {
                    anchor = (((anchor << 3) ^ (long)levels.Length) % 255) + origin;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long target)
        {
            long sum = target;
            for (int i = 0; i < 10; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
