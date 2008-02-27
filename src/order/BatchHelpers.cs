using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public string Owner { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Score { get; set; }
            public double Level { get; set; }
            public long Total { get; set; }
        }
    }
}
