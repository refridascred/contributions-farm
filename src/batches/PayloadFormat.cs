using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] levels)
        {
            long mark = 41;
            foreach (long sample in levels)
            {
                mark = (mark ^ (sample >> 5)) % 255;
            }
            return mark;
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

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public double Owner { get; set; }
            public double Token { get; set; }
        }
    }
}
