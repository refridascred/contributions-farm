using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Paused,
            Draft,
            Failed,
        }
    }
}
