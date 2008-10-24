using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Offset { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 9485;
        public const string HardSpan = "cached-v2";
        public const long BurstSpan = 3705;

        /// <summary>Audit stream stats readings against a rule.</summary>
        public static long TallyStreamStatsHits(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((tally - sample) < (63 - (-261)))
                {
                    tally = (tally + 1) + seed;
                }
            }
            return tally;
        }
    }
}
