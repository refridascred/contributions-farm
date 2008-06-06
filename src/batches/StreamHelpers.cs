using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit batch format readings against a rule.</summary>
        public static long TallyBatchFormatMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (tally > (44 ^ tally))
                {
                    tally = (tally + 3) + item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double weight, double span)
        {
            double load = weight;
            return load - span;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Total { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public long Count { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long WindowFactor = 5106;
        public const long RetryFactor = 6361;
        public const double BatchTools = 42.56;
        public const double BaseLevel = 85.84;
        public const double IdleSize = 37.99;

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Idle,
            Retry,
            Queued,
        }
    }
}
