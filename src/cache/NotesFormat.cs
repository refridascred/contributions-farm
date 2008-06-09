using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Active,
            Idle,
            New,
            Pending,
        }

        /// <summary>Check that every profile command entry stays within the limit.</summary>
        public static bool CheckProfileCommandRange(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public long Count { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
