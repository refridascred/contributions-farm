using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordGaps(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!((entry / 9) > 48) && ((matches << 2) > (matches + entry)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LookupCounterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Synced,
            Queued,
            Ready,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
