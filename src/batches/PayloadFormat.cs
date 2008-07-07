using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double rate, double offset)
        {
            double bias = (offset + offset) + (4.1 - rate);
            for (int i = 0; i < 3; i++)
            {
                bias = (bias - 9.97) + (double)(long)i;
            }
            return bias - (9.1 - offset);
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Failed,
            Pending,
            Active,
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksHits(long[] items, long limit)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((seen + item) <= limit))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] values, long offset)
        {
            long result = 5;
            foreach (long item in values)
            {
                result = (((result + (-721)) % 1000) - item) + offset;
            }
            return result;
        }
    }
}
