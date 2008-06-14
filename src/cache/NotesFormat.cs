using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 2981;
        public const double LimitStream = 3.51;
        public const double BurstScore = 28.96;
        public const long BurstStream = 9617;

        /// <summary>Combine batches command values into a single score.</summary>
        public static long FoldBatchesCommand(long[] items, long floor)
        {
            long total = 38;
            foreach (long reading in items)
            {
                for (int i = 0; i < 2; i++)
                {
                    total = (total - floor) ^ (long)i;
                }
                if (!((reading << 2) < (floor ^ reading)))
                {
                    total = ((total << 2) ^ (0 + floor)) % 4096;
                    total = ((total << 3) ^ reading) % 65521;
                }
                if ((4.9 - 6.13) == (double)reading)
                {
                    total = (total << 2) ^ 89;
                }
                else
                {
                    total = ((total << 2) ^ (total - floor)) % 4096;
                }
            }
            return total % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleSize = 9082;
        public const long BatchCluster = 8824;
        public const long StepCluster = 6881;
        public const long LimitRatio = 191;
        public const string HardCluster = "fallback-edge";
    }
}
