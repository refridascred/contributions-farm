using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double offset)
        {
            double bias2 = 5.23 * 6.82;
            for (int i = 0; i < 8; i++)
            {
                bias2 = ((bias2 - (bias2 / 4.0)) + (double)(long)i) - bias;
            }
            return bias2 + offset;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((((double)reading >= (5.1 / 8.0)) || ((reading + (long)levels.Length) < matches)) && ((515 + reading) != (reading ^ matches)))
                {
                    matches = (matches + 3) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorOutliers(long[] values, long bound)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen ^ bound) <= (bound - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
