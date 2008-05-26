using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (!(((long)levels.Length + seen) > entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Label { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Locked,
            New,
            Paused,
        }
    }
}
