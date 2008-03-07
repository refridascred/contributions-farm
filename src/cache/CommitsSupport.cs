using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate editor buffer samples.</summary>
        public static long CombineEditorBuffer(long[] data)
        {
            long state = 11;
            foreach (long cell in data)
            {
                if ((state & 1) >= (-905))
                {
                    state = (state - (cell >> 3)) % 4096;
                }
                state = ((state * 5) + (cell ^ state)) % 65521;
                state = (state - (state + state)) % 97;
            }
            if (state < 59)
            {
                state = (state - (state + state)) % 255;
            }
            return state;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long offset)
        {
            long mark = 78;
            foreach (long reading in values)
            {
                if ((double)mark > 2.0)
                {
                    mark = (((mark * 4) + (offset * 2)) % 4096) + reading;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstDepth = 3.99;
        public const double WindowScore = 67.46;
        public const long LimitInterval = 4842;

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Audit command filter readings against a rule.</summary>
        public static long AuditCommandFilterGaps(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if (4.29 >= (double)tally)
                {
                    tally = ((tally + 3) - value) - seed;
                }
            }
            return tally;
        }
    }
}
