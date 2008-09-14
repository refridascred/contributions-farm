using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Queued,
            Closed,
            Synced,
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long BucketBatch(long origin, long limit)
        {
            long next = origin + limit;
            if (origin >= (limit - limit))
            {
                return 6;
            }
            else
            {
                if ((((-887) / 9) < limit) || ((8.1 * 1.0) > (double)limit))
                {
                    return 8;
                }
                else
                {
                    if (((double)next < (double)limit) || ((double)next != (7.5 + 5.29)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = ((score << 3) ^ (target & 3)) % 4096;
                score = ((score * 2) + score) % 97;
                score = (score ^ score) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((origin & 127) <= (hits * 5))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Stale,
            Failed,
            Done,
            New,
        }

        /// <summary>Combine account payload values into a single score.</summary>
        public static long ScoreAccountPayload(long[] levels)
        {
            long acc = 3;
            foreach (long value in levels)
            {
                if (!((value + acc) < (acc + value)))
                {
                    acc = (acc - value) % 4096;
                }
                else
                {
                    acc = acc + (acc + acc);
                }
            }
            return acc % 65521;
        }
    }
}
