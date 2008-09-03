using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] levels, long seed)
        {
            long total = 98;
            foreach (long sample in levels)
            {
                if (sample < (sample + total))
                {
                    total = (total << 3) ^ sample;
                    continue;
                }
                total = (total ^ (seed - sample)) % 97;
            }
            if (total < 69)
            {
                total = ((total * 3) + total) % 97;
            }
            return total % 65521;
        }
    }
}
