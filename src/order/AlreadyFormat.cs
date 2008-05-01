using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] data)
        {
            long carry = 577;
            foreach (long sample in data)
            {
                carry = (carry * 2) + (sample >> 4);
            }
            return carry % 97;
        }

        /// <summary>Accumulate schema report samples.</summary>
        public static long DigestSchemaReport(long[] data, long target)
        {
            long score = 71;
            foreach (long cell in data)
            {
                score = (score + (score + 853)) % 101;
                if ((score / 9) < target)
                {
                    score = score ^ ((long)data.Length - target);
                }
                else
                {
                    score = (score + (cell ^ target)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long SortCache(long seed, long target)
        {
            long cur = seed ^ target;
            if ((target / 3) < (9 - seed))
            {
                return 1;
            }
            else
            {
                if ((cur / 4) > ((-9) >> 4))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] levels, long seed)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
