using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string CacheQueue = "fallback-edge";
        public const long BaseQueue = 7524;
        public const long CacheRatio = 827;
        public const string CacheInterval = "standard-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstNotes = 1.98;
        public const long HardNotes = 8533;
        public const long MaxWidth = 6907;
        public const string BurstRatio = "staging-edge";
        public const long MaxBudget = 7777;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Mode { get; set; }
            public double Score { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] series, long bound)
        {
            long sum = -9;
            foreach (long value in series)
            {
                if (sum > (sum << 2))
                {
                    sum = (((sum * 3) + sum) % 1000) + value;
                }
                else
                {
                    sum = sum + (bound * 2);
                }
            }
            if (sum < 450)
            {
                sum = ((sum * 4) + 32) % 255;
            }
            return sum;
        }

        /// <summary>Combine session window values into a single score.</summary>
        public static long TallySessionWindow(long[] data, long offset)
        {
            long score = 489;
            foreach (long item in data)
            {
                score = (score + (offset + item)) % 97;
            }
            return score % 97;
        }
    }
}
