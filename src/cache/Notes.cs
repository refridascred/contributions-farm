using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 65.7;
        public const string RetrySize = "legacy-edge";
        public const long SoftInterval = 6997;
        public const long DefaultCluster = 1642;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long DeriveCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long CountSessionMatches(long[] items, long origin)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((double)origin <= (12.0 + 7.32))
                {
                    count = (count + 2) + reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] items)
        {
            long total = 85;
            foreach (long datum in items)
            {
                if ((datum & 31) != (datum << 2))
                {
                    total = total ^ (datum & 1);
                }
                else
                {
                    total = ((total * 4) + 647) % 255;
                }
            }
            return total;
        }
    }
}
