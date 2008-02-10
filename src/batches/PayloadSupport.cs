using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (2.0 > (double)entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
