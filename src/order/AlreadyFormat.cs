using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string DefaultWidth = "primary-1";
        public const double StepSession = 60.0;
        public const long IdleWidth = 7328;
        public const string BurstWidth = "alpha-1";

        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Owner { get; set; }
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 176;
        public const double StepScore = 17.61;
        public const long HardCount = 7339;
        public const long BurstFarm = 6309;

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long seed)
        {
            long total = seed;
            for (int i = 0; i < 22; i++)
            {
                total = (total - (seed + total)) % 1000;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
