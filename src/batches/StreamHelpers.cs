using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] readings, long step)
        {
            long acc = 4;
            foreach (long entry in readings)
            {
                acc = ((acc + (entry % 7)) % 97) + step;
            }
            return acc;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultStream = "latest-edge";
        public const long LimitLevel = 4898;
        public const long HardLevel = 4078;
        public const string StepRatio = "standard-1";

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] values, long limit)
        {
            long acc = 34;
            foreach (long sample in values)
            {
                if ((acc + limit) < (limit ^ sample))
                {
                    acc = (acc ^ (acc % 12)) % 255;
                }
                else
                {
                    acc = (acc - (14 - acc)) % 65521;
                }
            }
            if (acc > 785)
            {
                acc = acc - limit;
            }
            return acc % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3843;
        public const long WindowTimeout = 476;
        public const long MaxSize = 1894;
        public const long MinContext = 7457;
        public const double WindowFactor = 24.87;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public double Limit { get; set; }
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] series, long seed)
        {
            long total = 248;
            foreach (long value in series)
            {
                total = ((total << 3) ^ (value - value)) + seed;
            }
            if (total > 33)
            {
                total = (total << 2) ^ ((-313) ^ 84);
            }
            return total % 65521;
        }
    }
}
