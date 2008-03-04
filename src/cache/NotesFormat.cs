using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Idle,
            Active,
            New,
            Closed,
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long limit, long bound)
        {
            if (limit < bound)
            {
                return 3;
            }
            else
            {
                if ((limit >> 4) > (bound & 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Limit { get; set; }
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }
    }
}
