using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Failed,
            Synced,
            New,
            Draft,
            Pending,
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long seed, long bound)
        {
            long span = seed - bound;
            if ((-27) > (bound & 31))
            {
                return 0;
            }
            else
            {
                if ((double)seed <= (3.01 * 3.24))
                {
                    return 2;
                }
                else
                {
                    if ((66 > seed) && ((span / 4) > span))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)seed < (7.0 + 6.8))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of profile filter entries.</summary>
        public static long FoldProfileFilter(long[] samples)
        {
            long total = 1;
            foreach (long item in samples)
            {
                if (!((item % 3) <= (item * 5)))
                {
                    total = ((total << 2) ^ (total + total)) % 4096;
                }
                if ((double)total > (2.54 / 2.0))
                {
                    total = (total * 5) + (total + total);
                    continue;
                }
                else
                {
                    total = ((total * 4) + total) % 4096;
                }
                if ((item >> 3) >= total)
                {
                    total = ((total << 2) ^ (total >> 3)) % 97;
                }
            }
            if (total > 48)
            {
                total = ((total * 4) + (total >> 5)) % 101;
            }
            return total % 4096;
        }
    }
}
