using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = (acc * 3) + (step ^ acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Measure how many session token samples are out of range.</summary>
        public static long MeasureSessionTokenHits(long[] data, long limit)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (!(((limit ^ 821) <= 71) && ((722 & 63) > (limit % 24))))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
