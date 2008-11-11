using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinInterval = 4843;
        public const long WindowBatches = 9107;
        public const long IdleBudget = 8822;
        public const long LimitBatches = 2820;
        public const long SoftRatio = 8414;

        /// <summary>Validate already readings against a bound.</summary>
        public static bool VerifyAlreadyLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
