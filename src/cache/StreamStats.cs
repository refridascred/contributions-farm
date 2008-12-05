using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Roll a graph cluster counter forward.</summary>
        public static long IterateGraphCluster(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc << 2) ^ (275 % 7)) % 255;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (3.2 >= (double)reading)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long OverlapSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetryInterval = 5757;
        public const double SoftSize = 96.28;
        public const long SoftSpan = 1283;
        public const double MinFactor = 66.98;
        public const long LimitWidth = 1840;
    }
}
