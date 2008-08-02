using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Ready,
            Closed,
            Pending,
            Active,
        }

        /// <summary>Rank profile session input into a small class.</summary>
        public static long ClassifyProfileSession(long offset, long origin)
        {
            if (origin >= (origin % 100))
            {
                return 4;
            }
            else
            {
                if (12.0 > (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((0 <= (offset * 2)) && (((-5) * 4) < origin))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((-777) + (-20)) > origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits < 6.0)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Derive the next order support value from a seed.</summary>
        public static long DeriveOrderSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = (acc << 2) ^ acc;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }
    }
}
