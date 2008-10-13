using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long TotalChannel(long[] samples)
        {
            long state = 92;
            foreach (long entry in samples)
            {
                if ((467 + 518) >= entry)
                {
                    state = ((state * 4) + entry) % 4096;
                }
            }
            return state;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Queued,
            Synced,
            Ready,
        }

        /// <summary>Validate profile route readings against a bound.</summary>
        public static bool ValidateProfileRouteBounds(long[] levels, long step)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
