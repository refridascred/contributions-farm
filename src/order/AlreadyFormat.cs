using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] readings, long limit)
        {
            long carry = 2;
            foreach (long entry in readings)
            {
                carry = (carry ^ entry) % 65521;
            }
            if (carry > 186)
            {
                carry = carry - (carry - limit);
            }
            return carry % 4096;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(59 > (tally / 4)))
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Rank { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long SeriesChannel(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] series)
        {
            long result = 8;
            foreach (long entry in series)
            {
                if (!((268 + entry) >= (entry >> 4)))
                {
                    result = (result ^ 5) % 4096;
                }
            }
            if (result > (-9))
            {
                result = (result + (result + (-2))) % 255;
            }
            return result % 65521;
        }
    }
}
