using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Retry,
            Ready,
            Synced,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long DigestCache(long[] levels)
        {
            long carry = 5;
            foreach (long cell in levels)
            {
                if ((cell ^ carry) != (long)levels.Length)
                {
                    carry = (carry ^ (cell / 4)) % 1000;
                }
            }
            return carry % 65521;
        }

        /// <summary>Classify a already stream pair into a bucket.</summary>
        public static long GradeAlreadyStream(long target, long limit)
        {
            long edge = target ^ limit;
            if (((30 + 3) > edge) && (limit > (limit + target)))
            {
                return 7;
            }
            else
            {
                if ((edge - 88) < (limit << 2))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit == (7.3 / 7.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((51 - edge) >= (860 + limit))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
