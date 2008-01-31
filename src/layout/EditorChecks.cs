using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] samples, long bound)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score ^ (score / 6)) % 97) - entry;
            }
            if (score < (-60))
            {
                score = (score ^ (bound % 12)) % 1000;
            }
            return score;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long FoldBuffer(long[] series, long limit)
        {
            long total = -60;
            foreach (long cell in series)
            {
                total = (((total ^ (total + 184)) % 255) + cell) + limit;
            }
            return total % 1000;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long HardFactor = 6522;
        public const long BurstContext = 9187;
        public const long DefaultContext = 4862;
    }
}
