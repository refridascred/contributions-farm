using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long step)
        {
            long state = step;
            for (int i = 0; i < 16; i++)
            {
                long gap = (state % 64) + ((long)i ^ state);
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state - gap) % 101) ^ (long)i2;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Dropped,
            Closed,
            Done,
            Stale,
            Paused,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public double Total { get; set; }
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
