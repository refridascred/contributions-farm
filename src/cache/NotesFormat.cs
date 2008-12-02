using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Pending,
            Synced,
            Active,
        }

        /// <summary>Check that every batch checks entry stays within the limit.</summary>
        public static bool GuardBatchChecksBounds(long[] values, long floor)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public string Weight { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
            public double Ratio { get; set; }
        }
    }
}
