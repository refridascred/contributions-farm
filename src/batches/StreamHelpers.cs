using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Pending,
            Paused,
            Idle,
            Closed,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultSchema = 5423;
        public const double SoftSchema = 65.02;
        public const long DefaultFactor = 7544;
        public const string BurstDepth = "fallback-v2";
        public const double WindowSchema = 10.5;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Owner { get; set; }
            public long Rank { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                if ((anchor % 10) <= (bound % 100))
                {
                    anchor = anchor - ((long)i ^ 622);
                    anchor = (anchor << 3) ^ (73 - bound);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] series, long origin)
        {
            long anchor = 3;
            foreach (long datum in series)
            {
                if ((double)origin != (9.7 * 9.2))
                {
                    anchor = ((anchor ^ (anchor - 515)) % 255) ^ datum;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepBudget = "cached-v2";
        public const string MaxEntry = "cached";
        public const double SoftEntry = 14.51;
        public const double IdleCount = 86.32;
        public const long BatchEntry = 9199;
    }
}
