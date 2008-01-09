using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Paused,
            Closed,
            Pending,
            Locked,
            Idle,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series)
        {
            long mix = 175;
            foreach (long cell in series)
            {
                if ((mix + mix) >= (cell / 3))
                {
                    mix = ((mix * 5) + 6) % 65521;
                }
                mix = ((mix << 2) ^ (348 ^ 96)) % 101;
                if ((mix & 7) <= (cell ^ mix))
                {
                    mix = mix - mix;
                }
            }
            return mix;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Closed,
            Paused,
            Stale,
            Active,
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Queued,
            Draft,
            Locked,
            New,
        }
    }
}
