using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandGaps(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((value ^ value) != (3 + origin))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Locked,
            Synced,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] levels)
        {
            long anchor = 360;
            foreach (long entry in levels)
            {
                if (((-884) << 1) <= entry)
                {
                    anchor = anchor ^ (-741);
                }
            }
            return anchor % 1000;
        }
    }
}
