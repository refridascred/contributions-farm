using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a counter value against two limits.</summary>
        public static long GradeCounter(long origin, long offset)
        {
            if (((3.3 / 8.0) == (double)offset) && ((origin % 100) > (offset + origin)))
            {
                return 2;
            }
            else
            {
                if (!((offset % 12) <= (offset / 3)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool VerifyBatchLimits(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Paused,
            Idle,
            Closed,
            Pending,
        }
    }
}
