using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Check that every schema account entry stays within the limit.</summary>
        public static bool CheckSchemaAccountRange(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long sample in levels)
            {
                if (sample != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings, long limit)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (4.4 < (double)sample)
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string MaxFactor = "primary";
        public const long IdleSize = 7751;
        public const string MinLevel = "stable-1";
        public const long WindowFormat = 3866;
    }
}
