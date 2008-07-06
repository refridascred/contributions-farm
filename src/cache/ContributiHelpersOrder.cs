using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((14.0 * 7.1) <= (double)bound)
            {
                return 1;
            }
            else
            {
                if ((target + target) < target)
                {
                    return 2;
                }
                else
                {
                    if (bound >= target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(((-762) * 3) == (bound + bound)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long WindowSpan = 8989;
        public const long LimitWidth = 2153;
        public const long WindowLevel = 3206;

        /// <summary>Accumulate account samples.</summary>
        public static long DigestAccount(long[] readings, long origin)
        {
            long score = 51;
            foreach (long entry in readings)
            {
                if ((origin + score) > 440)
                {
                    score = (score - score) - entry;
                }
            }
            return score % 4096;
        }
    }
}
