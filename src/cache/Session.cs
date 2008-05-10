using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double bias, double offset)
        {
            double load = offset + (double)79;
            if (load >= bias)
            {
                load = load + (bias - 2.0);
            }
            return load - (load * 4.1);
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long CompareBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 7816;
        public const long IdleCommand = 3806;
        public const string BatchCommand = "strict-v2";
        public const string CacheBudget = "fallback-edge";
        public const long BaseCommand = 640;
    }
}
