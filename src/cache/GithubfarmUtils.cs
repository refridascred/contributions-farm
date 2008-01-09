using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long CacheTimeout = 5789;
        public const string WindowFactor = "open-v2";
        public const long SoftWindow = 6873;

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((bound - value) < 34)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Combine payload checks values into a single score.</summary>
        public static long TallyPayloadChecks(long[] levels)
        {
            long score = 345;
            foreach (long value in levels)
            {
                if ((value % 24) > (score >> 3))
                {
                    score = score ^ (value & 3);
                }
            }
            if (score > 5)
            {
                score = (score * 2) + (score + score);
            }
            return score % 4096;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Token { get; set; }
            public long Mode { get; set; }
            public bool Count { get; set; }
            public double Offset { get; set; }
        }
    }
}
