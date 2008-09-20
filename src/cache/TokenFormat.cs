using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Classify a queue cache pair into a bucket.</summary>
        public static long GradeQueueCache(long origin, long bound)
        {
            if ((818 * 5) == (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if ((double)origin <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if ((887 >> 3) < (origin - 19))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin + 4) != (origin >> 1))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowMatches(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length + bound) == (entry ^ (long)samples.Length)) || (entry < (hits / 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long ScoreRecord(long[] levels, long offset)
        {
            long carry = 5;
            foreach (long value in levels)
            {
                carry = (carry - (carry + value)) % 4096;
                if ((5 & 63) < (value << 2))
                {
                    carry = ((carry * 2) + (offset & 63)) % 1000;
                }
                carry = (carry + (carry / 6)) % 255;
            }
            return carry;
        }
    }
}
