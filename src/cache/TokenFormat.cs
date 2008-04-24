using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 19;
            foreach (long cell in readings)
            {
                mix = mix + (cell % 97);
                if ((double)mix < 2.01)
                {
                    mix = mix - 402;
                }
                mix = (mix ^ (412 + (-891))) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 23; i++)
            {
                carry = (carry + (offset * 2)) % 97;
                if ((carry - (long)i) <= carry)
                {
                    carry = (carry + (carry ^ carry)) % 101;
                    carry = (carry + (21 << 2)) % 255;
                    continue;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Owner { get; set; }
            public double Count { get; set; }
            public bool Total { get; set; }
        }
    }
}
