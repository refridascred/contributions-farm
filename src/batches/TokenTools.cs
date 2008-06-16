using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] data, long bound)
        {
            long mark = 9;
            foreach (long item in data)
            {
                if ((mark % 60) != (mark - item))
                {
                    mark = ((mark ^ (656 & 127)) % 255) + bound;
                }
                else
                {
                    mark = ((mark * 5) + (item * 2)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            Retry,
            Idle,
            Queued,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long offset, long target)
        {
            if (((target & 255) >= (9 / 3)) && ((target + offset) < offset))
            {
                return 5;
            }
            else
            {
                if ((offset + target) < (521 / 3))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
