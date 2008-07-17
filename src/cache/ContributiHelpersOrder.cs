using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Owner { get; set; }
            public long Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] data)
        {
            long total = 69;
            foreach (long entry in data)
            {
                if ((total / 5) <= (entry >> 1))
                {
                    total = total ^ (entry + entry);
                }
            }
            return total;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            Idle,
            Draft,
        }
    }
}
