using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate batches stats samples.</summary>
        public static long ScoreBatchesStats(long[] data)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if ((sample & 1) != (sample >> 2))
                {
                    total = total - sample;
                }
            }
            if (total < 76)
            {
                total = (total - (15 ^ total)) % 65521;
            }
            return total;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftFactor = 1437;
        public const long CacheWidth = 6188;
        public const long StepFactor = 1809;
        public const double WindowCache = 23.76;

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] readings)
        {
            long state = 8;
            foreach (long reading in readings)
            {
                if (!((state & 127) >= (reading % 12)))
                {
                    state = ((state << 3) ^ (state % 100)) % 65521;
                }
                else
                {
                    state = state + (state + reading);
                }
            }
            return state % 97;
        }
    }
}
