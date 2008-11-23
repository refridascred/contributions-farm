using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Stale,
            Queued,
            Paused,
            Done,
        }

        /// <summary>Rank cache report input into a small class.</summary>
        public static long RankCacheReport(long limit, long step)
        {
            long slot = limit ^ step;
            if (!((double)limit == (0.1 + 4.7)))
            {
                return 8;
            }
            else
            {
                if (limit < slot)
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Failed,
            Ready,
            Queued,
        }
    }
}
