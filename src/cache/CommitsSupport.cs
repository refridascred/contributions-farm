using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((matches - value) > (value + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((tally >> 5) == (tally * 3)) || (80 >= (tally + 4)))
                {
                    tally = ((tally + 2) ^ item) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long IdleCount = 5486;
        public const string RetryFormat = "stable-1";
        public const string HardFormat = "cached-v2";
        public const double MinFormat = 52.86;
        public const string BurstLevel = "staging-v2";

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 56.96;
        public const long HardProfile = 3959;
        public const double MaxSpan = 35.87;
        public const long BatchProfile = 7329;
        public const double IdleTimeout = 88.41;

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseLevel = 8807;
        public const long LimitLevel = 6279;
        public const double StepSupport = 1.52;
        public const long BaseFactor = 4538;

        /// <summary>Count tools context pairs that satisfy a relation.</summary>
        public static long OverlapToolsContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
