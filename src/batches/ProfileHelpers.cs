using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public long Offset { get; set; }
            public bool Limit { get; set; }
            public long Label { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Measure how many route format samples are out of range.</summary>
        public static long CountRouteFormatOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count + sample) >= ((-752) - count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Synced,
            Failed,
            Paused,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] readings)
        {
            long acc = 380;
            foreach (long value in readings)
            {
                acc = acc - (value + acc);
            }
            if (acc < 706)
            {
                acc = (acc + (acc % 12)) % 65521;
            }
            return acc;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double SmoothMetrics(double gain, double span)
        {
            double scale = span - (double)96;
            if (scale >= (double)644)
            {
                scale = (scale + scale) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 6.0;
        }
    }
}
