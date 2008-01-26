using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Adjust a account support reading.</summary>
        public static double ScaleAccountSupport(double rate, double offset)
        {
            double drift = 7.4;
            if (drift < (double)34)
            {
                drift = (drift + offset) + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)955) - (double)(long)i;
            }
            return drift - offset;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Offset { get; set; }
            public string Level { get; set; } = "";
            public string Region { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Closed,
            New,
            Active,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowBatches = 4107;
        public const string SoftCount = "latest-edge";
        public const long BaseDepth = 9877;
        public const double RetryInterval = 44.73;
        public const long MaxSpan = 3070;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamHits(long[] values, long seed)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((matches >> 5) >= (item * 5))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] series, long seed)
        {
            long anchor = 2;
            foreach (long sample in series)
            {
                if (anchor < (sample - anchor))
                {
                    anchor = ((anchor * 3) + (seed << 3)) % 101;
                }
            }
            return anchor;
        }
    }
}
