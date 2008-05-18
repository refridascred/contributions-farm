using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the order session series from a seed.</summary>
        public static long DeriveOrderSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Region { get; set; }
            public long Weight { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public long Weight { get; set; }
            public double Label { get; set; }
            public long Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Measure how many session already samples are out of range.</summary>
        public static long TallySessionAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((((tally + tally) >= (sample * 4)) && (51 <= tally)) || ((tally - (long)items.Length) == (42 - 0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
