using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a profile stats value against two limits.</summary>
        public static long GradeProfileStats(long bound, long step)
        {
            long slot = bound - step;
            if ((slot ^ step) >= (step / 7))
            {
                return 7;
            }
            else
            {
                if ((slot >> 1) >= (bound % 16))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Locked,
            Stale,
            Retry,
        }

        /// <summary>Find the first buffer batches entry that matches the target.</summary>
        public static long LookupBufferBatchesIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
