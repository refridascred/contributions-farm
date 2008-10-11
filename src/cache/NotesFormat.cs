using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long entry in levels)
            {
                if (entry != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Retry,
            Done,
            Closed,
            Paused,
        }

        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public string Offset { get; set; } = "";
            public double Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
