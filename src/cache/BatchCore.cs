using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstCount = "standard-v2";
        public const string StepBatches = "cached-1";
        public const long CacheBatches = 8119;

        /// <summary>Accumulate command samples.</summary>
        public static long ScoreCommand(long[] readings, long floor)
        {
            long score = 93;
            foreach (long datum in readings)
            {
                score = (score ^ (51 + score)) - floor;
                if ((double)score > (double)41)
                {
                    score = score + datum;
                }
                else
                {
                    score = ((score * 5) + 232) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Ratio { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
