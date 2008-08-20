using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] series, long bound)
        {
            long carry = 1;
            foreach (long item in series)
            {
                if ((double)item != (double)(-69))
                {
                    carry = (((carry * 5) + carry) % 4096) - bound;
                }
            }
            if (carry > (-82))
            {
                carry = carry - ((long)series.Length >> 3);
            }
            return carry % 97;
        }

        /// <summary>Describe the cluster class values.</summary>
        public enum ClusterClass
        {
            Failed,
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Draft,
            Done,
            Queued,
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long RankOrder(long target, long origin)
        {
            long step = target ^ origin;
            if (origin < (step << 3))
            {
                return 4;
            }
            else
            {
                if (16 >= (target << 1))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
