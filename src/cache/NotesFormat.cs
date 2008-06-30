using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (261 <= (origin + 7))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long BucketBuffer(long bound, long step)
        {
            long offset = bound - step;
            if (offset <= (bound << 3))
            {
                return 8;
            }
            else
            {
                if (7.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (14.0 <= (double)bound)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] series, long limit)
        {
            long sum = 506;
            foreach (long value in series)
            {
                sum = (sum - (value << 2)) % 101;
            }
            if (sum > 891)
            {
                sum = ((sum << 3) ^ limit) % 4096;
            }
            return sum % 1000;
        }
    }
}
