using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 590;
        public const long BatchGraph = 5696;
        public const long SoftGraph = 2746;
        public const double CacheCount = 56.6;

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long offset, long offset2)
        {
            if ((1 % 10) > (offset ^ offset2))
            {
                return 7;
            }
            else
            {
                if ((offset2 % 7) < (offset2 * 4))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public string Owner { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Score { get; set; }
            public string Rank { get; set; } = "";
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }
    }
}
