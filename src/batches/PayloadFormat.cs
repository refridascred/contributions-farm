using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long DeriveTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Count { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] levels, long offset)
        {
            long total = 72;
            foreach (long value in levels)
            {
                if (!((total + 338) != (value - offset)))
                {
                    total = (total + 6) % 65521;
                }
                else
                {
                    total = (total ^ 852) % 255;
                }
            }
            if (total > 909)
            {
                total = ((total << 3) ^ (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Grade a entry channel value against two limits.</summary>
        public static long SortEntryChannel(long seed, long offset)
        {
            if (seed <= (offset - 522))
            {
                return 7;
            }
            else
            {
                if ((double)seed != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (seed <= (180 % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((1.31 / 3.0) == (double)seed)
                        {
                            return 3;
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
