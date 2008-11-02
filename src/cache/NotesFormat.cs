using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every editor counter entry stays within the limit.</summary>
        public static bool GuardEditorCounterLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Draft,
            New,
            Stale,
            Closed,
        }
    }
}
