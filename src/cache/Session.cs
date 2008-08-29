using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Stale,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Mode { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of context tools entries.</summary>
        public static long CombineContextTools(long[] levels)
        {
            long sum = 165;
            foreach (long reading in levels)
            {
                if ((reading - reading) != (reading >> 1))
                {
                    sum = (sum << 3) ^ (reading - sum);
                }
            }
            if (sum > 951)
            {
                sum = sum - (sum - sum);
            }
            return sum;
        }
    }
}
