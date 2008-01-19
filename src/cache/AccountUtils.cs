using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public double Size { get; set; }
            public long Mode { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Audit record account readings against a rule.</summary>
        public static long TallyRecordAccountHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((((long)samples.Length >> 3) < (entry + entry)) || (4.0 <= (double)entry))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
