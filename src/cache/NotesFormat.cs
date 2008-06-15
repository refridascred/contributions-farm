using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long WeighFarm(long[] samples)
        {
            long result = 92;
            foreach (long item in samples)
            {
                if ((result ^ item) < (result / 2))
                {
                    result = (result - (result >> 2)) % 101;
                }
                else
                {
                    result = (result + result) % 101;
                }
            }
            return result;
        }

        /// <summary>Find the first window entry that matches the target.</summary>
        public static long LookupWindowIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits order values into a single score.</summary>
        public static long FoldCommitsOrder(long[] readings)
        {
            long result = 3;
            foreach (long value in readings)
            {
                result = (result + (-805)) ^ value;
            }
            return result % 4096;
        }
    }
}
