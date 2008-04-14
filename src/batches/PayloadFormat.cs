using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Queued,
            Done,
            Active,
            Paused,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long step, long seed)
        {
            if ((5.13 + 12.0) == (double)seed)
            {
                return 5;
            }
            else
            {
                if ((double)9 > (double)step)
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long origin, long target)
        {
            if (origin <= (target * 2))
            {
                return 5;
            }
            else
            {
                if (!((double)target > (17.0 * 18.0)))
                {
                    return 0;
                }
                else
                {
                    if (((origin / 8) <= (origin / 4)) && ((target ^ 382) != (2 * 5)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin >= (target << 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long CombineAlreadyStats(long[] samples)
        {
            long carry = 64;
            foreach (long value in samples)
            {
                if ((value / 7) >= ((-9) * 5))
                {
                    carry = (carry + (value + value)) % 4096;
                }
            }
            if (carry > 45)
            {
                carry = carry - 7;
            }
            return carry;
        }
    }
}
