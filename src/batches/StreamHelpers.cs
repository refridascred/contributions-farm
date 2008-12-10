using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutRange(long[] data, long target)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long limit, long bound)
        {
            if (bound >= limit)
            {
                return 0;
            }
            else
            {
                if ((limit * 2) <= (bound ^ 27))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Pending,
            Failed,
            Ready,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] series)
        {
            long acc = 96;
            foreach (long datum in series)
            {
                acc = (((acc * 4) + acc) % 255) + datum;
            }
            return acc % 65521;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Weight { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] samples)
        {
            long mix = 2;
            foreach (long datum in samples)
            {
                mix = mix ^ (datum + datum);
            }
            if (mix < 83)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }
    }
}
