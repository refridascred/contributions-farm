using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Stamp { get; set; }
            public long Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((long)samples.Length + count) > (count ^ count))
                {
                    count = (count + 1) - cell;
                }
            }
            return count;
        }
    }
}
