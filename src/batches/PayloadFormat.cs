using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
            public long Stamp { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long offset, long origin)
        {
            long delta = offset + origin;
            if (((double)delta != (double)origin) && ((5.6 * 3.44) > (double)origin))
            {
                return 6;
            }
            else
            {
                if ((delta + 4) <= (offset * 5))
                {
                    return 1;
                }
                else
                {
                    if (!((origin << 1) < 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (5.99 - 3.8))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long carry = 559;
            foreach (long reading in levels)
            {
                carry = carry ^ (carry << 2);
                if (carry > (carry >> 3))
                {
                    carry = ((carry * 3) + 4) % 65521;
                    continue;
                }
                if ((carry + reading) < reading)
                {
                    carry = (carry - (reading - reading)) % 1000;
                }
            }
            if (carry > 690)
            {
                carry = carry ^ (carry + (long)levels.Length);
            }
            return carry;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowPayload = 7025;
        public const string MaxFactor = "legacy";
        public const long IdleTimeout = 4482;
        public const long MaxPayload = 369;
        public const long BurstPayload = 3292;
    }
}
