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

        /// <summary>Validate format session readings against a bound.</summary>
        public static bool GuardFormatSessionLimits(long[] items, long origin)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public bool Weight { get; set; }
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
