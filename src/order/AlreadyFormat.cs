using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Roll a format batches counter forward.</summary>
        public static long StepFormatBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool CheckRouteLimits(long[] samples, long target)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double mean = (span + gain) / 2.0;
            if (mean < (3.37 * 5.18))
            {
                mean = mean + (7.0 * 2.9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.54) + (double)(long)i;
            }
            return mean - (5.14 / 5.0);
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Label { get; set; }
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            Stale,
            Done,
            Locked,
        }
    }
}
