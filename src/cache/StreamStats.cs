using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the queue window series from a seed.</summary>
        public static long IterateQueueWindow(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (seed < (reading ^ 439))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Size { get; set; }
            public string Ratio { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double MinAlready = 91.02;
        public const string LimitAlready = "strict-1";
        public const double HardAlready = 33.78;
        public const double MaxLevel = 11.86;
        public const long MinFactor = 4172;
    }
}
