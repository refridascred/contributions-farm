using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] series)
        {
            long total = 250;
            foreach (long sample in series)
            {
                total = ((total << 2) ^ 9) + sample;
            }
            return total;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 34.27;
        public const long LimitFarm = 571;
        public const double MinBudget = 27.14;

        /// <summary>Look up the position of a filter sample.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
