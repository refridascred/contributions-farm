using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryHits(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (((tally + 592) >= tally) || ((double)tally == (4.8 / 4.0)))
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Mode { get; set; }
            public bool Count { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Look up the position of a notes account sample.</summary>
        public static long SeekNotesAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
