using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public long Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxTimeout = 233;
        public const long DefaultChannel = 4414;
        public const string BaseChannel = "local";
        public const long BatchChannel = 4794;

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((956 - 952) < reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1527;
        public const string WindowRatio = "standard-edge";
        public const long BurstRatio = 8920;
    }
}
