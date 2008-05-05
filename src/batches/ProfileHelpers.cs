using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            New,
            Queued,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (tally <= 768)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Failed,
            Active,
            Queued,
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (limit >= (value & 1))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double bias)
        {
            double rate = gain / 6.0;
            if (rate < bias)
            {
                rate = rate + 5.83;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - (rate * 17.0)) + (double)(long)i;
            }
            return rate + (4.0 - bias);
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
