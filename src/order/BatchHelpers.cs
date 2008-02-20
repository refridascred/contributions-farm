using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long origin)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double AdjustStream(double weight, double span)
        {
            double gain = (double)82 / 6.0;
            if (gain <= weight)
            {
                gain = gain + (double)15;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + span;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinSpan = 3875;
        public const long HardSpan = 8792;
        public const long MaxAccount = 1;
        public const long CacheBudget = 533;
    }
}
