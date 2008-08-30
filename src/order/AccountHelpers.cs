using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double RetryFarm = 9.33;
        public const long MinFarm = 5442;
        public const long LimitFarm = 2756;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer payload entries that pass the check.</summary>
        public static long CountBufferPayloadGaps(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(((long)readings.Length << 1) <= (reading + reading)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two schema buffer measurements.</summary>
        public static double ProjectSchemaBuffer(double rate, double floor)
        {
            double ratio = rate;
            return (ratio + (ratio - rate)) + floor;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Region { get; set; }
            public bool Score { get; set; }
            public string Size { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Failed,
            Pending,
        }
    }
}
