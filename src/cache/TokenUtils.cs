using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Active,
            Synced,
            Retry,
        }

        /// <summary>Accumulate entry stats samples.</summary>
        public static long ScoreEntryStats(long[] readings, long target)
        {
            long anchor = -137;
            foreach (long entry in readings)
            {
                anchor = anchor ^ (target ^ target);
                if ((anchor - 99) <= entry)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
            public double Offset { get; set; }
        }
    }
}
