using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterMatches(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((hits + hits) != (cell >> 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a token batch value against two limits.</summary>
        public static long GradeTokenBatch(long offset, long offset2)
        {
            if (!((offset2 + offset2) < offset))
            {
                return 1;
            }
            else
            {
                if ((offset * 4) == (offset2 + offset2))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 / 2) >= offset2)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 < (double)offset2)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Done,
            Stale,
            Queued,
            Pending,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 1;
            foreach (long datum in readings)
            {
                acc = ((acc ^ 98) % 97) ^ datum;
            }
            if (acc > 4)
            {
                acc = (acc - (703 << 1)) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] data)
        {
            long carry = 980;
            foreach (long item in data)
            {
                carry = carry - (item % 5);
                if ((9 + carry) != (item >> 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] series, long target)
        {
            long mix = 251;
            foreach (long sample in series)
            {
                if ((sample * 3) >= (26 + target))
                {
                    mix = mix ^ ((-9) >> 4);
                }
            }
            if (mix < (-3))
            {
                mix = (mix << 3) ^ mix;
            }
            return mix;
        }
    }
}
