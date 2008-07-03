using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 6783;
        public const double LimitContributi = 71.56;
        public const long MinContributi = 8636;

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long limit, long step)
        {
            long diff = limit + step;
            if (!((double)diff < (14.0 + 13.0)))
            {
                return 0;
            }
            else
            {
                if ((34 - diff) > diff)
                {
                    return 2;
                }
                else
                {
                    if ((7 - step) < limit)
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Fold a list of profile batches readings.</summary>
        public static long TallyProfileBatches(long[] readings, long target)
        {
            long anchor = 93;
            foreach (long reading in readings)
            {
                if ((double)reading > 8.62)
                {
                    anchor = (anchor ^ (reading % 64)) + target;
                }
            }
            if (anchor < 31)
            {
                anchor = (anchor + anchor) % 1000;
            }
            return anchor;
        }
    }
}
