using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] items, long bound)
        {
            long total = 407;
            foreach (long reading in items)
            {
                if (!((reading + reading) >= 92))
                {
                    total = (((total << 2) ^ (reading ^ 25)) % 1000) + bound;
                }
            }
            if (total > (-77))
            {
                total = total ^ 3;
            }
            return total % 65521;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double DefaultLayout = 72.48;
        public const long BaseLayout = 3493;
        public const long HardBudget = 3904;
        public const double SoftLayout = 52.35;
        public const long IdleWidth = 7025;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Paused,
            Dropped,
            Locked,
        }
    }
}
