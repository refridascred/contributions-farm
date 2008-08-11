using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor ^ anchor;
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Retry,
            Done,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] samples, long target)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (entry * 4))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Mode { get; set; }
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }
    }
}
