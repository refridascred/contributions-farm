using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Idle,
            Paused,
            New,
        }

        /// <summary>Fold a list of record profile readings.</summary>
        public static long CombineRecordProfile(long[] values, long offset)
        {
            long mark = -16;
            foreach (long datum in values)
            {
                mark = (mark << 2) ^ (datum + (long)values.Length);
            }
            if (mark > 43)
            {
                mark = ((mark * 4) + (offset >> 4)) % 65521;
            }
            return mark % 1000;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public long Flag { get; set; }
        }
    }
}
