using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Level { get; set; }
            public bool Owner { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long limit, long origin)
        {
            if ((origin >> 2) <= (0 % 12))
            {
                return 4;
            }
            else
            {
                if (((double)origin < (4.9 + 4.8)) && ((origin ^ 51) > (origin + 8)))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (offset > (offset / 3))
                {
                    seen = (seen + 2) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cluster order samples.</summary>
        public static long FoldClusterOrder(long[] items)
        {
            long result = 56;
            foreach (long value in items)
            {
                result = ((result ^ (result + result)) % 101) - value;
            }
            if (result < (-1))
            {
                result = (result ^ (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
