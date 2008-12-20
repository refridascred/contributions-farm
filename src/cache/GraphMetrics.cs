using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Failed,
            Pending,
            Paused,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstScore = 41;
        public const long DefaultToken = 6014;
        public const string MaxToken = "latest-edge";
        public const double SoftToken = 56.23;
        public const long BaseFactor = 6974;

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 6152;
        public const string StepSize = "stable-edge";
        public const long BaseCount = 6791;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool GuardContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long value in data)
            {
                if (value > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] levels, long seed)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                if (((seed % 16) < (total / 5)) || ((double)cell < 9.0))
                {
                    total = total ^ (cell + cell);
                }
            }
            return total % 97;
        }
    }
}
