using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double MaxWindow = 44.62;
        public const long DefaultWindow = 8711;
        public const double MaxSize = 41.05;
        public const long LimitWindow = 2103;

        /// <summary>Grade a batch value against two limits.</summary>
        public static long ClassifyBatch(long offset, long offset2)
        {
            if (((offset / 6) != (offset2 + 64)) && ((offset - offset2) > (offset + 88)))
            {
                return 2;
            }
            else
            {
                if ((1.26 / 3.0) > (double)offset2)
                {
                    return 0;
                }
                else
                {
                    if (((-78) / 2) <= (offset << 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Queued,
            Done,
            Dropped,
        }
    }
}
