using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the checks token series from a seed.</summary>
        public static long SeriesChecksToken(long seed)
        {
            long result = seed;
            for (int i = 0; i < 23; i++)
            {
                result = ((result << 3) ^ seed) % 101;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate schema payload samples.</summary>
        public static long DigestSchemaPayload(long[] items)
        {
            long sum = 854;
            foreach (long sample in items)
            {
                if (((sum << 2) > (sum ^ sum)) && ((double)sum <= (0.8 / 4.0)))
                {
                    sum = (sum + (sum + sample)) % 65521;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Synced,
            Stale,
            Paused,
        }
    }
}
