using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double LimitBatches = 51.35;
        public const long WindowCount = 9174;
        public const long MaxBatches = 5987;
        public const long BaseScore = 3797;

        /// <summary>Audit stream layout readings against a rule.</summary>
        public static long CountStreamLayoutOutliers(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((((datum + count) <= (datum << 3)) && (7.0 > (double)datum)) && ((double)count < 2.2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (datum < (tally >> 5))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
