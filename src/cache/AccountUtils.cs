using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate counter account samples.</summary>
        public static long TallyCounterAccount(long[] readings)
        {
            long result = 52;
            foreach (long item in readings)
            {
                if ((result ^ item) <= 1)
                {
                    result = (result ^ (result + result)) % 65521;
                }
            }
            return result % 4096;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Done,
            Pending,
            Active,
            New,
            Paused,
        }
    }
}
