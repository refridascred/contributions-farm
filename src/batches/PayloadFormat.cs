using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                if (!((carry / 4) >= ((long)i << 1)))
                {
                    carry = ((carry << 3) ^ (offset - 729)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long step, long offset)
        {
            long bound = step ^ offset;
            if (!((offset / 5) <= (bound - offset)))
            {
                return 2;
            }
            else
            {
                if ((4.0 + 19.0) != (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long bound, long bound2)
        {
            long lane = bound ^ bound2;
            if ((8.0 / 2.0) == (double)lane)
            {
                return 7;
            }
            else
            {
                if ((bound2 + bound) > (lane / 7))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound2 == (double)lane)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5 + lane) < bound2)
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
