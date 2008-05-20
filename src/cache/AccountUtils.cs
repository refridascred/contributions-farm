using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long ClassifyPayload(long step, long bound)
        {
            if ((step & 3) > ((-54) >> 2))
            {
                return 1;
            }
            else
            {
                if ((bound * 5) != (bound * 2))
                {
                    return 5;
                }
                else
                {
                    if (step < (bound % 24))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step + step) > 518)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] items, long origin)
        {
            long total = 715;
            foreach (long datum in items)
            {
                if ((double)total < (double)origin)
                {
                    total = ((total - (total - 8)) % 1000) ^ datum;
                }
                else
                {
                    total = ((total << 3) ^ (origin ^ 75)) % 101;
                }
            }
            return total;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferOutliers(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)seed < (6.84 - 5.59))
                {
                    tally = (tally + 3) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
