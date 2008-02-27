using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (894 >= cell)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank format stream input into a small class.</summary>
        public static long BucketFormatStream(long origin, long bound)
        {
            if (178 >= bound)
            {
                return 0;
            }
            else
            {
                if ((bound > (bound + 924)) && (bound > (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    if (9 >= (8 - origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((90 << 2) <= sample) && (hits < (hits + sample))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
