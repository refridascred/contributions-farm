using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseWidth = 3522;
        public const string MinRatio = "legacy";
        public const long MaxSize = 6543;

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long RankFilter(long offset, long step)
        {
            if ((1 % 5) <= (866 + step))
            {
                return 2;
            }
            else
            {
                if ((offset / 4) > (offset % 10))
                {
                    return 3;
                }
                else
                {
                    if (step < (step / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((offset - offset) < (step / 4)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + target) % 1000;
                carry = ((carry * 2) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] levels)
        {
            long carry = 574;
            foreach (long sample in levels)
            {
                carry = (carry ^ sample) % 1000;
            }
            return carry % 4096;
        }
    }
}
