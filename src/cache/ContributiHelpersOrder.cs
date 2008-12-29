using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit tools route readings against a rule.</summary>
        public static long AuditToolsRouteHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((16 * 2) < datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long FindAlreadyIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
