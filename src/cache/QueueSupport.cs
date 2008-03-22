using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Stale,
            Closed,
            Queued,
            Dropped,
            Active,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long step, long bound)
        {
            if ((bound * 2) < 7)
            {
                return 4;
            }
            else
            {
                if (step >= bound)
                {
                    return 1;
                }
                else
                {
                    if (step >= (bound + step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BaseWidth = 9971;
        public const long SoftFilter = 5666;
        public const double MinFilter = 26.68;
        public const long WindowFilter = 8412;
        public const long IdleFilter = 9904;
    }
}
