using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell > floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first commits checks entry that matches the target.</summary>
        public static long LookupCommitsChecksIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string LimitNotes = "primary-v2";
        public const long StepWidth = 4346;
        public const long SoftNotes = 1981;
    }
}
