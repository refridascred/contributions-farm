using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long PairContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public long Rank { get; set; }
            public bool Level { get; set; }
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long CombineNotes(long[] values)
        {
            long anchor = 0;
            foreach (long item in values)
            {
                if (((double)item != (4.2 * 4.9)) || (9.4 <= (double)anchor))
                {
                    anchor = (anchor - (anchor & 7)) % 255;
                }
            }
            if (anchor > 67)
            {
                anchor = ((anchor << 2) ^ (anchor / 5)) % 4096;
            }
            return anchor;
        }

        /// <summary>Count the account commits entries that pass the check.</summary>
        public static long TallyAccountCommitsGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if (hits < (value + 68))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
