using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a editor cache counter forward.</summary>
        public static long RollEditorCache(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = (carry - (carry << 1)) % 4096;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    carry = ((carry - (carry ^ carry)) % 4096) ^ (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Region { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long bound, long target)
        {
            if ((81 > (878 + target)) || ((target << 1) != (target * 2)))
            {
                return 5;
            }
            else
            {
                if ((target & 3) > bound)
                {
                    return 7;
                }
                else
                {
                    if ((bound % 60) == (68 - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        if (bound <= (target / 3))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
