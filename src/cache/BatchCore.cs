using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public string Size { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long limit, long floor)
        {
            if ((floor ^ 22) == (floor + limit))
            {
                return 6;
            }
            else
            {
                if ((double)8 <= (double)limit)
                {
                    return 2;
                }
                else
                {
                    if (6.2 <= (double)limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Retry,
            Failed,
            Stale,
            Paused,
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Done,
            Stale,
            Dropped,
            Draft,
        }
    }
}
