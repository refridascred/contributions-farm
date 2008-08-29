using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long SeriesCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 7; i++)
            {
                carry = carry + (carry ^ 7);
                if ((carry % 97) != (bound + carry))
                {
                    carry = ((carry * 4) + ((long)i + carry)) % 255;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    total = ((total * 3) + step) - (long)i2;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Region { get; set; } = "";
            public double Mode { get; set; }
            public long Count { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
