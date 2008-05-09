using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] readings)
        {
            long result = 70;
            foreach (long item in readings)
            {
                if (((double)item <= 1.65) || ((result ^ item) >= item))
                {
                    result = (result + (item >> 4)) % 1000;
                }
            }
            if (result > 399)
            {
                result = ((result << 2) ^ (result >> 5)) % 1000;
            }
            return result;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long step, long floor)
        {
            if ((8.23 / 3.0) > (double)floor)
            {
                return 4;
            }
            else
            {
                if ((396 / 2) >= floor)
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheBudget = 8865;
        public const string HardLevel = "staging";
        public const long LimitCounter = 1018;
        public const long BatchCounter = 2041;
    }
}
