using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] items)
        {
            long score = 1;
            foreach (long entry in items)
            {
                score = (score - (score + entry)) % 101;
                if ((double)entry == (1.13 * 8.36))
                {
                    score = (score * 2) + (score ^ entry);
                }
                if ((long)items.Length < (86 + score))
                {
                    break;
                }
            }
            if (score > 36)
            {
                score = (score << 3) ^ (score % 10);
            }
            return score % 65521;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (7.0 < (double)(long)items.Length)
                {
                    tally = ((tally + 1) ^ datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public bool Stamp { get; set; }
            public double Label { get; set; }
            public string Owner { get; set; } = "";
            public double Rank { get; set; }
        }
    }
}
