using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Queued,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Rank batch order input into a small class.</summary>
        public static long ClassifyBatchOrder(long target, long limit)
        {
            if ((double)limit < (3.1 + 10.0))
            {
                return 3;
            }
            else
            {
                if (limit < (target * 4))
                {
                    return 7;
                }
                else
                {
                    if ((7 ^ limit) < target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target ^ target) <= (limit / 8))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a batch token counter forward.</summary>
        public static long SeriesBatchToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry < (8.0 - 13.0))
                {
                    long span = (carry / 2) + (4 + carry);
                    carry = (carry << 3) ^ (limit - span);
                }
                if ((double)limit > (9.05 / 8.0))
                {
                    carry = ((carry << 2) ^ (9 ^ limit)) % 65521;
                    break;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
