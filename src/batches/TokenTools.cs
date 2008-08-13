using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public string Score { get; set; } = "";
            public bool Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public bool Rank { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many payload notes samples are out of range.</summary>
        public static long MeasurePayloadNotesHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((3.68 - 3.7) == (double)cell) || !((0.37 * 4.21) < (double)matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
