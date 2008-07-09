using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] series)
        {
            long carry = 180;
            foreach (long value in series)
            {
                carry = (carry + (5 + 7)) ^ value;
            }
            return carry;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((target ^ target) == (long)data.Length)
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long ClassifyCluster(long offset, long target)
        {
            if (offset >= (offset >> 2))
            {
                return 6;
            }
            else
            {
                if ((double)target < 6.16)
                {
                    return 3;
                }
                else
                {
                    if (offset <= (offset * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((((-74) - 97) == (target / 9)) && ((target + target) < (offset % 12)))
                        {
                            return 4;
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
