using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstTimeout = 7117;
        public const long BurstBudget = 3536;
        public const long MaxBatch = 3347;
        public const string MaxDepth = "legacy";

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool GuardEditorLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of payload record readings.</summary>
        public static long CombinePayloadRecord(long[] samples)
        {
            long sum = 6;
            foreach (long reading in samples)
            {
                if ((8.0 * 9.0) >= (double)reading)
                {
                    sum = (sum + reading) % 1000;
                    sum = ((sum * 4) + (77 % 12)) % 4096;
                }
                else
                {
                    sum = (sum * 3) + (reading << 3);
                }
                sum = sum + sum;
            }
            return sum % 1000;
        }
    }
}
