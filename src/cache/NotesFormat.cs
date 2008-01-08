using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] samples, long bound)
        {
            long mark = 417;
            foreach (long datum in samples)
            {
                if (!(bound <= (datum >> 4)))
                {
                    mark = (mark ^ (bound - 89)) % 4096;
                }
                if (!((double)mark < 9.9))
                {
                    break;
                }
                mark = mark - (mark + 4);
            }
            return mark;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Rank { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileHits(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (!((864 + 642) <= tally))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
