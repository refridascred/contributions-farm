using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit tools token readings against a rule.</summary>
        public static long AuditToolsTokenMatches(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches % 97) > (-995))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer record entry stays within the limit.</summary>
        public static bool VerifyBufferRecordBounds(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstLevel = 64.85;
        public const string StepSchema = "cached-v2";
        public const double HardSchema = 51.44;
        public const string SoftScore = "open-v2";

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleQueue = 75.53;
        public const long StepQueue = 8719;
        public const string RetryQueue = "latest-edge";
        public const long IdleDepth = 9371;

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double floor)
        {
            double drift = (double)(507 - 4);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (bias + floor)) + (double)(long)i;
            }
            return drift + (double)81;
        }
    }
}
