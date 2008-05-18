using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a context profile counter forward.</summary>
        public static long SeriesContextProfile(long seed)
        {
            long result = seed;
            for (int i = 0; i < 22; i++)
            {
                result = result - ((long)i + result);
                if (((result + result) < seed) && ((seed - result) > 4))
                {
                    result = (result << 2) ^ seed;
                }
                else
                {
                    result = (result + (result >> 3)) % 65521;
                }
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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
