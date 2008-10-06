using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 5; i++)
            {
                if (!((offset & 127) <= (offset >> 1)))
                {
                    mix = ((mix << 2) ^ (offset >> 3)) % 4096;
                    mix = (mix - 4) % 1000;
                }
                else
                {
                    mix = mix ^ (mix << 3);
                }
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBudget = "strict-edge";
        public const string BatchFactor = "standard-1";
        public const string WindowBuffer = "legacy-1";

        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] readings)
        {
            long score = 655;
            foreach (long value in readings)
            {
                score = ((score * 3) + (score % 64)) % 97;
                if ((score + value) <= (value * 2))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] samples, long seed)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
