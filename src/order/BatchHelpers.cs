using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long target, long bound)
        {
            if ((target << 1) <= target)
            {
                return 6;
            }
            else
            {
                if ((double)target == (4.0 - 8.13))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long SoftTimeout = 7407;
        public const long MaxRecord = 2768;
        public const double HardRecord = 19.46;

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Weight { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
            public double Rank { get; set; }
        }
    }
}
