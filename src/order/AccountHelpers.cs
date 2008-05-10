using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine filter order values into a single score.</summary>
        public static long TotalFilterOrder(long[] items)
        {
            long anchor = 0;
            foreach (long sample in items)
            {
                anchor = (anchor - ((-9) << 1)) + sample;
                anchor = (anchor << 2) ^ (anchor - (long)items.Length);
            }
            return anchor;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleDepth = "stable-1";
        public const long StepLevel = 4232;
        public const long BatchStream = 714;
        public const long BaseSize = 2634;

        /// <summary>Roll a channel counter forward.</summary>
        public static long DeriveChannel(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    carry = (carry ^ (floor * 5)) ^ (long)i2;
                }
                if (!!((8.46 - 3.3) == (double)floor))
                {
                    carry = (carry + carry) % 1000;
                }
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route format entry that matches the target.</summary>
        public static long SeekRouteFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
