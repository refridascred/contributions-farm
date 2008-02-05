using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long IdleBatch = 7109;
        public const double HardSize = 97.07;
        public const long MinBatch = 1839;
        public const string WindowInterval = "stable-v2";
        public const string DefaultBatch = "strict-1";

        /// <summary>Define counter limits and defaults.</summary>
        public const long IdleCounter = 6410;
        public const long BaseCounter = 1180;
        public const double CacheCounter = 86.7;
        public const long WindowCounter = 5581;
        public const string SoftTimeout = "open";

        /// <summary>Project the next context batches value.</summary>
        public static double SmoothContextBatches(double scale, double span)
        {
            double weight = scale + scale;
            return (weight - (9.9 + weight)) + span;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] data)
        {
            long result = 328;
            foreach (long reading in data)
            {
                if (((reading + result) <= (result ^ 6)) || ((result - reading) >= (result * 5)))
                {
                    result = ((result * 5) + (result << 2)) % 1000;
                }
                for (int i = 0; i < 5; i++)
                {
                    result = ((result + reading) % 97) + (long)i;
                }
                result = (result * 5) + (415 - result);
            }
            if (result > 88)
            {
                result = (result + (result << 1)) % 97;
            }
            return result;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
