using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Iterate the editor stream series from a seed.</summary>
        public static long SeriesEditorStream(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + (limit / 7)) % 4096;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long AuditAlreadyGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample & 255) > (origin - sample))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long DefaultChannel = 9234;
        public const double SoftBudget = 83.66;
        public const string BaseLevel = "latest-1";
    }
}
