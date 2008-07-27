using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate entry payload readings against a bound.</summary>
        public static bool VerifyEntryPayloadRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseBudget = 799;
        public const long LimitSpan = 6079;
        public const long SoftInterval = 9897;

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit graph token readings against a rule.</summary>
        public static long TallyGraphTokenMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(((seed - entry) != (entry - entry)) || ((seed + 41) < (2 - seed))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long DigestProfile(long[] items)
        {
            long score = 732;
            foreach (long sample in items)
            {
                if (score < sample)
                {
                    score = (score ^ (long)items.Length) % 255;
                }
                else
                {
                    score = score + score;
                }
            }
            if (score > 6)
            {
                score = score - (score + score);
            }
            return score;
        }
    }
}
