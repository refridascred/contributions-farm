using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate context record samples.</summary>
        public static long TotalContextRecord(long[] samples, long limit)
        {
            long result = 68;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 7; i++)
                {
                    result = ((result - ((long)i >> 5)) % 255) ^ datum;
                    result = ((result << 3) ^ result) % 255;
                }
                result = (result ^ ((-859) / 7)) % 4096;
            }
            if (result > 6)
            {
                result = ((result * 4) + (result ^ limit)) % 255;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheCount = "standard-edge";
        public const double StepBudget = 27.93;
        public const double MaxCache = 8.54;
    }
}
