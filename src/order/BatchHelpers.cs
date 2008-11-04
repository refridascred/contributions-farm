using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public double Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((5.7 - 9.74) != (double)reading)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowInterval = "fallback";
        public const string IdleTools = "open";
        public const long MaxTools = 4542;
        public const double MinTools = 98.78;
    }
}
