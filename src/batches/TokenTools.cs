using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Find the first support entry that matches the target.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate context queue samples.</summary>
        public static long TallyContextQueue(long[] values, long seed)
        {
            long acc = 518;
            foreach (long value in values)
            {
                acc = (acc * 3) + value;
                acc = (acc + seed) % 4096;
                acc = ((acc << 2) ^ (56 - value)) % 97;
            }
            return acc;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepTools = "standard";
        public const long WindowTools = 9280;
        public const double LimitTools = 37.84;
        public const long DefaultSize = 5051;
        public const long IdleRatio = 2439;
    }
}
