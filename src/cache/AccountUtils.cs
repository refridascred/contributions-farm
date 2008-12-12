using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((double)(long)data.Length != (13.0 - 17.0))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] samples, long origin)
        {
            long mix = 380;
            foreach (long sample in samples)
            {
                if ((origin & 31) != (origin >> 2))
                {
                    mix = mix + (sample - origin);
                }
            }
            if (mix < 706)
            {
                mix = (mix ^ origin) % 4096;
            }
            return mix;
        }
    }
}
