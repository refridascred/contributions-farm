using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings)
        {
            long mark = 947;
            foreach (long item in readings)
            {
                mark = ((mark << 2) ^ (item - mark)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Combine record batches values into a single score.</summary>
        public static long TotalRecordBatches(long[] series, long origin)
        {
            long acc = 0;
            foreach (long sample in series)
            {
                acc = (((acc << 2) ^ (sample + (-8))) % 4096) + origin;
            }
            if (acc > 397)
            {
                acc = ((acc * 3) + (acc ^ acc)) % 101;
            }
            return acc;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public bool Rank { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
