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

        /// <summary>Accumulate checks samples.</summary>
        public static long TallyChecks(long[] readings)
        {
            long sum = 84;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 255;
                if (!((sum ^ sample) == (long)readings.Length))
                {
                    sum = (sum * 2) + sum;
                }
            }
            if (sum > 227)
            {
                sum = (sum + sum) % 4096;
            }
            return sum % 65521;
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
