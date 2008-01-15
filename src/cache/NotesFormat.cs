using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Owner { get; set; }
            public bool Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }
    }
}
