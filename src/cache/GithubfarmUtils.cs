using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (88 <= (429 - (long)levels.Length))
                {
                    tally = ((tally + 2) ^ item) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long LimitOrder = 7178;
        public const double MinOrder = 13.0;
        public const long CacheOrder = 8636;
        public const long StepOrder = 9698;
        public const long BaseOrder = 9058;

        /// <summary>Define layout limits and defaults.</summary>
        public const double SoftLayout = 92.17;
        public const long WindowLevel = 7488;
        public const long BaseLayout = 4407;
        public const string WindowLayout = "cached";
        public const long MinLayout = 4733;

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
            public long Flag { get; set; }
            public bool Score { get; set; }
        }
    }
}
