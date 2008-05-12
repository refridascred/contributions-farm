using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryCount = 1888;
        public const long BaseFilter = 1366;
        public const long BurstFilter = 6439;

        /// <summary>Accumulate already samples.</summary>
        public static long TotalAlready(long[] data)
        {
            long state = 8;
            foreach (long datum in data)
            {
                if (((state << 1) <= datum) && ((datum << 1) != (datum / 4)))
                {
                    state = (state << 3) ^ (8 / 7);
                }
            }
            return state % 65521;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] data, long target)
        {
            long sum = 34;
            foreach (long cell in data)
            {
                if (target >= (cell + cell))
                {
                    sum = (sum ^ (sum / 4)) % 65521;
                    sum = ((sum << 3) ^ (sum / 3)) % 255;
                }
                sum = (sum ^ (sum >> 5)) % 65521;
                if ((9 + sum) < cell)
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string BatchWidth = "staging-1";
        public const long IdleSize = 8130;
        public const double WindowSession = 29.08;
        public const long StepRatio = 3136;

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public double Size { get; set; }
            public double Weight { get; set; }
            public double Limit { get; set; }
        }
    }
}
