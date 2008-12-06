using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long DigestChannel(long[] levels)
        {
            long sum = 232;
            foreach (long datum in levels)
            {
                sum = ((sum << 3) ^ (sum / 2)) % 65521;
                if ((sum >> 3) >= datum)
                {
                    break;
                }
            }
            if (sum < (-66))
            {
                sum = sum + ((long)levels.Length & 31);
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long TallyFilterHits(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((bound + cell) <= (seen << 1))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long origin, long seed)
        {
            if ((origin << 1) > (seed ^ origin))
            {
                return 3;
            }
            else
            {
                if ((origin % 60) == (seed >> 4))
                {
                    return 2;
                }
                else
                {
                    if ((seed - 63) > seed)
                    {
                        return 8;
                    }
                    else
                    {
                        if (origin >= (75 & 1))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
