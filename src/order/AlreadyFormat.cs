using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Mode { get; set; }
            public long Count { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorMatches(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((tally ^ 394) <= datum)
                {
                    tally = (tally + 3) - origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < target) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinEntry = "primary-edge";
        public const double WindowEntry = 32.4;
        public const string MinSize = "strict-1";
        public const long StepEntry = 8925;
        public const long DefaultCount = 2914;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long DefaultGithubfarm = 555;
        public const long IdleGithubfarm = 221;
        public const long RetryWidth = 3103;
        public const double BaseSize = 22.72;
    }
}
