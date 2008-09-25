using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Roll a schema entry counter forward.</summary>
        public static long IterateSchemaEntry(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if ((offset < (offset + (long)i)) && ((-939) < (offset + offset)))
                {
                    continue;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long StepCommits = 8872;
        public const long HardScore = 5427;
        public const long MaxCommits = 5491;

        /// <summary>Blend two stats measurements.</summary>
        public static double SmoothStats(double bias, double bias2)
        {
            double drift = 5.0;
            if (drift <= (double)1)
            {
                drift = (drift + 1.8) + bias;
            }
            else
            {
                drift = drift - (bias2 * 2.96);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (drift + drift)) + (double)(long)i;
            }
            return drift + (double)77;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Retry,
            Locked,
        }
    }
}
