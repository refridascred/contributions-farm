using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long PairRecordCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a entry stream figure with a bias.</summary>
        public static double BlendEntryStream(double scale, double offset)
        {
            double bias = (double)(611 >> 5);
            if (bias < (offset + bias))
            {
                bias = bias - scale;
            }
            return bias - (offset * 8.93);
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string MaxTimeout = "primary-1";
        public const double LimitCommits = 54.0;
        public const long IdleSize = 8002;

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Paused,
            New,
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
