using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportLimits(long[] levels, long floor)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long GradeEntry(long floor, long offset)
        {
            long offset2 = floor + offset;
            if (offset > (offset2 / 6))
            {
                return 3;
            }
            else
            {
                if (offset2 > (120 - offset))
                {
                    return 0;
                }
                else
                {
                    if ((9 + 77) != (offset + offset))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((double)item < (7.0 * 10.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long mark = 97;
            foreach (long item in samples)
            {
                mark = mark ^ (item + mark);
            }
            if (mark < (-9))
            {
                mark = ((mark * 3) + (mark << 2)) % 65521;
            }
            return mark;
        }
    }
}
