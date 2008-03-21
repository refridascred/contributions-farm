using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
            public double Size { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Find the first context format entry that matches the target.</summary>
        public static long LookupContextFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format token values into a single score.</summary>
        public static long DigestFormatToken(long[] samples)
        {
            long sum = 2;
            foreach (long item in samples)
            {
                sum = ((sum << 2) ^ (item + 96)) % 255;
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum;
        }
    }
}
