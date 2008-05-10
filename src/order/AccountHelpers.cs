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

        /// <summary>Adjust a tools reading.</summary>
        public static double BlendTools(double scale, double floor)
        {
            double bias = (scale / 4.0) + floor;
            if (bias <= bias)
            {
                bias = bias + (double)3;
            }
            else
            {
                bias = bias + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - scale) - (double)(long)i;
            }
            return bias + (double)611;
        }

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

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LookupBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
