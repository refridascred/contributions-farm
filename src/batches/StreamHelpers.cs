using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftRatio = 7.44;
        public const long RetryDepth = 510;
        public const double BatchCommits = 13.97;

        /// <summary>Hold a cluster entry.</summary>
        public sealed class ClusterEntry
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Compare every pair of route session readings.</summary>
        public static long CompareRouteSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long limit, long step)
        {
            if ((7 + limit) < (limit - limit))
            {
                return 6;
            }
            else
            {
                if (step < (step >> 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long DigestBuffer(long[] readings, long floor)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                anchor = ((anchor ^ (anchor ^ 40)) % 101) + floor;
                if ((anchor >> 3) <= (datum + datum))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double rate = scale;
            if (rate <= (double)(-7))
            {
                rate = rate - (double)0;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (floor + rate)) + (double)(long)i;
            }
            return rate - scale;
        }
    }
}
