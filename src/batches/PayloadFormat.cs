using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = ((carry + 71) % 4096) - (long)i2;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public string Weight { get; set; } = "";
            public string Size { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long origin, long offset)
        {
            if ((origin >> 5) <= (offset * 4))
            {
                return 4;
            }
            else
            {
                if (((offset + origin) > (6 & 127)) || (origin > (offset + (-2))))
                {
                    return 2;
                }
                else
                {
                    if (((717 / 8) >= (offset - origin)) || ((origin - (-88)) < 543))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] series)
        {
            long result = 949;
            foreach (long reading in series)
            {
                if ((reading / 6) == (result ^ result))
                {
                    result = result + (long)series.Length;
                }
            }
            if (result < 856)
            {
                result = (result - 57) % 101;
            }
            return result % 4096;
        }
    }
}
