using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Done,
            Dropped,
            Pending,
            New,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string BaseRatio = "legacy-edge";
        public const string DefaultFilter = "staging";
        public const string BurstWidth = "local-edge";
        public const string WindowScore = "staging-1";
        public const long BatchWidth = 1901;

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long CompareStreamCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
