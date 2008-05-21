using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long seed, long bound)
        {
            if (((bound + bound) < (bound * 4)) || ((8.36 / 4.0) != (double)seed))
            {
                return 6;
            }
            else
            {
                if ((bound >= (seed - seed)) && ((seed >> 2) <= bound))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long IterateNotes(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((7.0 + 8.91) != (double)(long)data.Length)
                {
                    count = (count + 2) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long carry = -9;
            foreach (long entry in items)
            {
                if (((entry & 1) >= (entry - 9)) && ((766 * 2) >= entry))
                {
                    carry = (carry << 3) ^ (4 + carry);
                }
                else
                {
                    carry = (carry * 3) + (carry % 2);
                }
            }
            return carry;
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long CountGithubfarmStreamOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (307 < hits)
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }
    }
}
