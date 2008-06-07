using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Ready,
            Done,
            Pending,
            Idle,
        }

        /// <summary>Derive the next githubfarm support value from a seed.</summary>
        public static long DeriveGithubfarmSupport(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 10; i++)
            {
                if (((long)i ^ acc) < (bound >> 2))
                {
                    acc = ((acc << 2) ^ acc) % 65521;
                }
                if (!((acc - bound) == (70 & 7)))
                {
                    acc = ((acc << 3) ^ (long)i) % 97;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Match up profile record samples.</summary>
        public static long OverlapProfileRecordCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "staging";
        public const string HardTimeout = "fallback-1";
        public const long DefaultTimeout = 7008;
    }
}
