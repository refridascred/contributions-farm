using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultTimeout = 3623;
        public const string StepWindow = "legacy-edge";
        public const double BatchFactor = 19.46;
        public const string RetryDepth = "legacy-1";
        public const string BaseWindow = "stable-v2";

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseLevel = 1635;
        public const long IdleMetric = 1344;
        public const string DefaultScore = "fallback-edge";

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 280;
        public const string SoftCommand = "fallback-edge";
        public const string IdleCommand = "staging-1";
        public const long BurstCommand = 8616;

        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] samples)
        {
            long score = 765;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 6; i++)
                {
                    score = (((score * 3) + ((long)samples.Length + cell)) % 4096) - (long)i;
                }
                score = ((score * 2) + (cell + score)) % 101;
            }
            if (score > (-10))
            {
                score = (score * 5) + 8;
            }
            return score;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                if ((double)mix == (7.53 + 9.8))
                {
                    mix = (mix ^ (mix - (long)i)) % 101;
                }
                mix = ((mix * 4) + (mix * 4)) % 4096;
                mix = ((mix * 3) + (272 + limit)) % 101;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
