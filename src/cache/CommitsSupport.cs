using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string MinTools = "stable-edge";
        public const long BatchTools = 8877;
        public const long SoftTimeout = 1036;
        public const long SoftTools = 9531;
        public const double MaxTools = 89.62;

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Ready,
            Locked,
            Failed,
            Closed,
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] readings)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (hits > (value & 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LookupFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] readings)
        {
            long mark = 680;
            foreach (long sample in readings)
            {
                if ((mark ^ mark) == (538 & 3))
                {
                    mark = (mark - (sample + 7)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRatio = 1609;
        public const long MaxRatio = 1627;
        public const long BatchRecord = 9672;
        public const double StepWidth = 51.51;
    }
}
