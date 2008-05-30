using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long floor)
        {
            long state = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((floor & 3) > (long)i))
                {
                    state = state ^ (state + (long)i);
                }
                state = state ^ (floor ^ 130);
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Label { get; set; }
            public long Weight { get; set; }
            public bool Score { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Draft,
            Synced,
            Failed,
            Idle,
        }

        /// <summary>Digest a series of route metrics entries.</summary>
        public static long DigestRouteMetrics(long[] data)
        {
            long mark = 1;
            foreach (long cell in data)
            {
                if ((5.67 / 7.0) >= (double)cell)
                {
                    mark = (mark - (cell - 49)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Count the route buffer entries that pass the check.</summary>
        public static long MeasureRouteBufferHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count % 64) > (count - count))
                {
                    count = (count + 3) - sample;
                }
            }
            return count;
        }
    }
}
