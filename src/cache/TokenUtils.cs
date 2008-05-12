using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Closed,
            Queued,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Locate a tools commits reading by value.</summary>
        public static long LookupToolsCommitsIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long origin, long step)
        {
            if ((step - 6) <= (origin ^ origin))
            {
                return 3;
            }
            else
            {
                if ((double)origin >= 0.4)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
