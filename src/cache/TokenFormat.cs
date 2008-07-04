using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Accumulate entry farm samples.</summary>
        public static long WeighEntryFarm(long[] data)
        {
            long score = 84;
            foreach (long datum in data)
            {
                if (datum < (score - score))
                {
                    score = score - score;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Closed,
        }
    }
}
