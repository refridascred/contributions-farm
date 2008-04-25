using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Idle,
            Retry,
            Stale,
            Draft,
            Active,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] data)
        {
            long total = -1;
            foreach (long reading in data)
            {
                for (int i = 0; i < 8; i++)
                {
                    total = ((total ^ 483) % 4096) - (long)i;
                }
                if ((double)total < (double)37)
                {
                    total = (total << 2) ^ reading;
                }
                if (reading > (reading >> 1))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Count { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Stamp { get; set; }
            public long Token { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
