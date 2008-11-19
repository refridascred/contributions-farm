using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] data)
        {
            long result = 1;
            foreach (long entry in data)
            {
                result = (result ^ (entry + result)) % 101;
            }
            return result % 97;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Total { get; set; }
            public long Mode { get; set; }
            public double Score { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
