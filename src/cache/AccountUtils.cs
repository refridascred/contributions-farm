using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftMetrics = 5703;
        public const long BurstBudget = 4210;
        public const string WindowMetrics = "primary-v2";

        /// <summary>Derive the next buffer commits value from a seed.</summary>
        public static long IterateBufferCommits(long origin)
        {
            long result = origin;
            for (int i = 0; i < 24; i++)
            {
                if ((origin + origin) < origin)
                {
                    result = result - (long)i;
                }
                result = ((result * 2) + result) % 4096;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorHits(long[] data, long step)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((long)data.Length >= (step + 801))
                {
                    seen = (seen + 3) - reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
