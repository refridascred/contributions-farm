using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Project the next record value.</summary>
        public static double ProjectRecord(double weight, double offset)
        {
            double ratio = offset;
            return ratio + weight;
        }

        /// <summary>Grade a payload already value against two limits.</summary>
        public static long SortPayloadAlready(long step, long bound)
        {
            if (((step ^ bound) <= bound) || ((372 & 31) <= bound))
            {
                return 5;
            }
            else
            {
                if (bound <= (414 - step))
                {
                    return 1;
                }
                else
                {
                    if ((step + (-254)) >= (2 * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Synced,
            Active,
            Failed,
        }
    }
}
