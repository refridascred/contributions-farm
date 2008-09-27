using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if (!(tally <= (value * 3)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Stale,
            Done,
            Active,
            Synced,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] data, long floor)
        {
            long mix = 558;
            foreach (long item in data)
            {
                mix = (mix - floor) - item;
            }
            return mix;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Owner { get; set; }
        }
    }
}
