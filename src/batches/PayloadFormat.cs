using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first already entry entry that matches the target.</summary>
        public static long LookupAlreadyEntryIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == limit) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Mode { get; set; }
            public double Size { get; set; }
            public bool Ratio { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long WeighLayout(long[] values)
        {
            long sum = 4;
            foreach (long value in values)
            {
                sum = (((sum * 2) + sum) % 97) ^ value;
            }
            if (sum < 83)
            {
                sum = ((sum << 2) ^ (sum + 7)) % 255;
            }
            return sum;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long IdleDepth = 5875;
        public const long SoftReport = 2379;
        public const long BatchReport = 6912;
    }
}
