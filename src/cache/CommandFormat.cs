using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] readings)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry * 5) + (carry * 5)) % 255;
                    carry = (carry << 3) ^ (long)i;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    carry = (carry + carry) - (long)i2;
                }
                if (((carry & 63) > 48) || ((95 >> 4) < (reading + 930)))
                {
                    carry = (carry ^ reading) % 101;
                }
            }
            if (carry < (-3))
            {
                carry = ((carry << 2) ^ carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Idle,
            Stale,
            Failed,
        }

        /// <summary>Combine profile session values into a single score.</summary>
        public static long WeighProfileSession(long[] samples, long bound)
        {
            long result = 6;
            foreach (long cell in samples)
            {
                result = (((result * 4) + (cell * 4)) % 4096) - bound;
            }
            return result;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
