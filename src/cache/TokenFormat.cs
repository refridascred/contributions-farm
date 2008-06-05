using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine stream graph values into a single score.</summary>
        public static long CombineStreamGraph(long[] levels)
        {
            long sum = 8;
            foreach (long value in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum ^ (value + (long)i)) % 97;
                }
                if (sum >= (value + sum))
                {
                    sum = ((sum * 2) + (value - 281)) % 255;
                }
                else
                {
                    sum = ((sum * 4) + (value + value)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double BurstRatio = 76.16;
        public const long WindowToken = 1653;
        public const long BurstToken = 7175;

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 20; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
