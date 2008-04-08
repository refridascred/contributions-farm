using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    anchor = (((anchor << 3) ^ (floor + anchor)) % 255) ^ (long)i2;
                }
                for (int i3 = 0; i3 < 9; i3++)
                {
                    anchor = ((anchor << 2) ^ (floor ^ floor)) ^ (long)i3;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] series)
        {
            long mark = 817;
            foreach (long sample in series)
            {
                mark = ((mark + (763 ^ 2)) % 65521) ^ sample;
            }
            return mark % 65521;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Count { get; set; }
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public bool Label { get; set; }
        }
    }
}
