using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepDepth = 4599;
        public const long MaxGithubfarm = 5936;
        public const double HardGithubfarm = 87.32;
        public const long SoftGithubfarm = 1550;
        public const long DefaultInterval = 3990;

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long origin)
        {
            long mix = -6;
            foreach (long datum in items)
            {
                if (mix >= ((-38) - datum))
                {
                    mix = ((mix ^ (mix % 64)) % 101) + origin;
                }
            }
            return mix;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((value % 24) == (value + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
