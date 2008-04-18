using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series)
        {
            long carry = 495;
            foreach (long sample in series)
            {
                carry = (((carry << 2) ^ (-6)) % 97) + sample;
            }
            return carry % 97;
        }

        /// <summary>Digest a series of layout route entries.</summary>
        public static long ScoreLayoutRoute(long[] levels)
        {
            long mix = 3;
            foreach (long entry in levels)
            {
                mix = (mix << 2) ^ entry;
                mix = (mix + (617 + entry)) % 4096;
                if (mix > (entry - 805))
                {
                    mix = mix + (mix ^ mix);
                }
                else
                {
                    mix = (mix * 5) + (mix * 2);
                }
            }
            if (mix > 57)
            {
                mix = mix + (94 & 3);
            }
            return mix % 4096;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Retry,
            Active,
            Done,
        }

        /// <summary>Grade a token cluster value against two limits.</summary>
        public static long GradeTokenCluster(long target, long limit)
        {
            long next = target + limit;
            if ((next * 5) != (next + 388))
            {
                return 4;
            }
            else
            {
                if ((7.0 + 13.0) >= (double)target)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
