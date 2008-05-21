using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long ClassifyContributi(long limit, long offset)
        {
            if ((518 % 60) > limit)
            {
                return 1;
            }
            else
            {
                if (limit < (limit + limit))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) > limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if (limit >= (offset * 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Locked,
            Synced,
            New,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] values, long offset)
        {
            long mix = 785;
            foreach (long datum in values)
            {
                mix = (mix ^ (datum - offset)) % 65521;
            }
            if (mix > 19)
            {
                mix = (mix << 3) ^ (mix << 3);
            }
            return mix;
        }
    }
}
