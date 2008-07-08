using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Failed,
            Retry,
            Paused,
            Closed,
            Draft,
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
