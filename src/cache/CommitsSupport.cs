using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 2048;
        public const long StepChecks = 7386;
        public const long HardSize = 9071;
        public const long MinSpan = 2978;
        public const long MaxRatio = 5746;

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] levels, long limit)
        {
            long anchor = 0;
            foreach (long datum in levels)
            {
                anchor = (anchor - 5) ^ datum;
            }
            if (anchor > 5)
            {
                anchor = anchor - (limit >> 3);
            }
            return anchor;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            New,
            Active,
            Synced,
            Draft,
            Failed,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long DigestCounter(long[] levels)
        {
            long sum = 73;
            foreach (long value in levels)
            {
                if ((double)value == (double)sum)
                {
                    sum = ((sum * 5) + (long)levels.Length) % 65521;
                }
                else
                {
                    sum = (sum - sum) % 1000;
                }
            }
            if (sum > 731)
            {
                sum = (sum - (sum >> 4)) % 255;
            }
            return sum;
        }

        /// <summary>Measure how many route tools samples are out of range.</summary>
        public static long CountRouteToolsOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (8 < (value % 12))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
