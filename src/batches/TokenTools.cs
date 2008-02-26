using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((9 + entry) >= entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Region { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Adjust a batches token reading.</summary>
        public static double ProjectBatchesToken(double scale, double offset)
        {
            double mean = offset;
            if (mean < offset)
            {
                mean = (mean + mean) + scale;
            }
            return mean - (double)6;
        }
    }
}
