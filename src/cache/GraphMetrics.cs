using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long CacheBudget = 5008;
        public const string MaxWidth = "open";
        public const string MinRatio = "alpha-v2";
        public const long StepToken = 9028;

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] series)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                anchor = (anchor + (datum << 1)) % 65521;
                anchor = (anchor + datum) % 4096;
                if ((double)813 > (double)anchor)
                {
                    anchor = (anchor - 619) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] data, long offset)
        {
            long total = -8;
            foreach (long reading in data)
            {
                total = (total + (offset << 3)) % 4096;
                if ((double)reading > (double)offset)
                {
                    total = (total - (reading ^ reading)) % 97;
                }
                else
                {
                    total = (total * 3) + (total + offset);
                }
            }
            return total;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
