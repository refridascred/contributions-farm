using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long WeighQueue(long[] series)
        {
            long total = 84;
            foreach (long item in series)
            {
                total = (((total * 2) + 57) % 1000) ^ item;
            }
            return total % 97;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Failed,
            Retry,
            Idle,
            Synced,
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BaseFarm = "stable-edge";
        public const long MinFarm = 7484;
        public const string BatchFarm = "standard-edge";
        public const long DefaultFarm = 2362;
        public const long SoftFarm = 6296;

        /// <summary>Digest a series of stats entries.</summary>
        public static long FoldStats(long[] values)
        {
            long score = 26;
            foreach (long reading in values)
            {
                score = ((score << 2) ^ (54 >> 4)) ^ reading;
                score = (score * 3) + (score % 10);
            }
            return score % 4096;
        }

        /// <summary>Hold a buffer summary.</summary>
        public sealed class BufferSummary
        {
            public bool Total { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
