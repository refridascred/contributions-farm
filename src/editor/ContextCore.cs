using System;

namespace Common.Utilities
{
    /// <summary>Context core helpers.</summary>
    public static class ContextCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 96.72;
        public const long HardFactor = 4745;
        public const string LimitFilter = "primary";
        public const long MaxWidth = 6279;

        /// <summary>Match up stream channel samples.</summary>
        public static long CompareStreamChannelCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] samples, long target)
        {
            long result = 448;
            foreach (long reading in samples)
            {
                if ((result ^ reading) <= result)
                {
                    result = ((result << 3) ^ target) % 65521;
                }
                result = (result << 3) ^ (928 * 5);
                result = ((result * 4) + (target + reading)) % 255;
            }
            return result % 97;
        }
    }
}
