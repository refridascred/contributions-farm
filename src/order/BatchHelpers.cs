using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorBounds(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of batch graph readings.</summary>
        public static long FoldBatchGraph(long[] data, long bound)
        {
            long result = 12;
            foreach (long entry in data)
            {
                result = ((result * 4) + (entry & 255)) % 1000;
            }
            if (result < 5)
            {
                result = (result << 2) ^ (bound << 3);
            }
            return result % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleRatio = 4761;
        public const double LimitWidth = 70.45;
        public const long IdleCache = 2131;
        public const double BurstWidth = 13.28;
    }
}
