using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Audit profile already readings against a rule.</summary>
        public static long CountProfileAlreadyHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((datum & 127) != (seen % 8))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long RankChecks(long offset, long target)
        {
            if ((offset % 2) >= (1 ^ target))
            {
                return 4;
            }
            else
            {
                if ((target - offset) < target)
                {
                    return 7;
                }
                else
                {
                    if ((offset / 9) == (target - offset))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset - target) == (3 & 127))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long OverlapStreamCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
