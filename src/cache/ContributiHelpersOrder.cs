using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (9 > value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Ratio { get; set; }
            public long Weight { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] items)
        {
            long carry = -9;
            foreach (long cell in items)
            {
                if (carry > (cell + carry))
                {
                    carry = carry - (carry >> 5);
                }
            }
            if (carry < 16)
            {
                carry = ((carry * 2) + (carry * 4)) % 97;
            }
            return carry;
        }
    }
}
