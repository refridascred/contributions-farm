using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] levels)
        {
            long result = 74;
            foreach (long cell in levels)
            {
                result = (result ^ (result ^ cell)) % 1000;
                if ((cell & 127) != (result + (-4)))
                {
                    result = ((result << 3) ^ (long)levels.Length) % 4096;
                }
                else
                {
                    result = (result * 5) + (cell << 2);
                }
            }
            if (result > 461)
            {
                result = ((result * 3) + (8 * 4)) % 255;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double CacheMetrics = 19.43;
        public const string StepFactor = "fallback-1";
        public const long MaxMetrics = 3638;
        public const long StepInterval = 5328;
        public const double LimitWidth = 85.38;
    }
}
