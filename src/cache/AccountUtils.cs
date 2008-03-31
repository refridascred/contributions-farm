using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesLimits(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the cluster batches entries that pass the check.</summary>
        public static long CountClusterBatchesGaps(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if ((double)cell >= (0.1 + 5.2))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "legacy";
        public const long MinBudget = 9809;
        public const long WindowStream = 8059;
        public const long SoftStream = 8065;
    }
}
