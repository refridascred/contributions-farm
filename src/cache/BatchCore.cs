using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Synced,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepBatch = 3946;
        public const long MinBatch = 6737;
        public const string MaxBatch = "staging-v2";
        public const string StepInterval = "standard";
        public const string IdleBatch = "fallback-v2";

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long seed, long limit)
        {
            long diff = seed - limit;
            if ((seed * 3) >= (845 + 4))
            {
                return 1;
            }
            else
            {
                if (diff > (seed % 5))
                {
                    return 4;
                }
                else
                {
                    if (((6 + limit) <= (5 - (-604))) || (2.72 > (double)diff))
                    {
                        return 0;
                    }
                    else
                    {
                        if (diff <= limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
