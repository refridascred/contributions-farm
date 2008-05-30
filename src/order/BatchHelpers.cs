using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Roll a stream layout counter forward.</summary>
        public static long DeriveStreamLayout(long bound)
        {
            long score = bound;
            for (int i = 0; i < 21; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleInterval = 5514;
        public const long IdleFactor = 3663;
        public const long SoftFactor = 6203;
        public const long BurstDepth = 3533;
        public const long BatchProfile = 1266;

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long IterateEditor(long bound)
        {
            long total = bound;
            for (int i = 0; i < 24; i++)
            {
                total = total + (total << 3);
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
