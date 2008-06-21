using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Retry,
            Idle,
            Ready,
            Queued,
            Draft,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally ^ datum) == (82 + tally))
                {
                    tally = (tally + 3) + seed;
                }
            }
            return tally;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            New,
            Ready,
            Idle,
        }
    }
}
