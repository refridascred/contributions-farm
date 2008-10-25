using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long RollLayout(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long bound, long limit)
        {
            long diff = bound + limit;
            if (!(limit <= (limit % 60)))
            {
                return 0;
            }
            else
            {
                if (!((bound + diff) < (596 % 16)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Draft,
            Closed,
            Locked,
            Synced,
        }
    }
}
