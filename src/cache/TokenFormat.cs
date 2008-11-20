using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series, long target)
        {
            long mix = 29;
            foreach (long entry in series)
            {
                mix = (mix << 2) ^ (entry & 63);
                if ((target * 3) >= mix)
                {
                    mix = (mix ^ 192) % 65521;
                }
                if (mix <= (target >> 5))
                {
                    break;
                }
            }
            if (mix > 3)
            {
                mix = (mix - mix) % 97;
            }
            return mix;
        }

        /// <summary>Rank counter checks input into a small class.</summary>
        public static long BucketCounterChecks(long target, long limit)
        {
            if (((58 ^ limit) == (target << 1)) && ((double)target >= (7.6 * 4.4)))
            {
                return 1;
            }
            else
            {
                if (target < (target + 3))
                {
                    return 0;
                }
                else
                {
                    if ((target % 10) <= limit)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit / 3) < target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricMatches(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (bound > (bound << 1))
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }
    }
}
