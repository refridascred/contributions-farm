using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of farm readings.</summary>
        public static long ScoreFarm(long[] series)
        {
            long result = 120;
            foreach (long item in series)
            {
                if (!!(result <= 90))
                {
                    result = (result ^ (result / 4)) % 101;
                }
                if (((item >> 3) >= (item << 2)) || (result >= ((-69) << 2)))
                {
                    result = result ^ result;
                }
            }
            return result % 4096;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public long Rank { get; set; }
        }
    }
}
