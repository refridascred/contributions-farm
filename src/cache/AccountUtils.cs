using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Flag { get; set; }
            public long Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Grade a contributi githubfarm value against two limits.</summary>
        public static long BucketContributiGithubfarm(long step, long seed)
        {
            long bound = step + seed;
            if (step >= (seed / 9))
            {
                return 4;
            }
            else
            {
                if (((7.07 + 16.0) <= (double)bound) || ((double)step > (double)seed))
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
