using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] values, long target)
        {
            long anchor = 27;
            foreach (long cell in values)
            {
                anchor = (((anchor << 3) ^ anchor) + cell) + target;
            }
            return anchor % 4096;
        }

        /// <summary>Derive the next token schema value from a seed.</summary>
        public static long SeriesTokenSchema(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 16; i++)
            {
                if (!(mark >= (mark - 4)))
                {
                    mark = (mark ^ (mark << 2)) % 97;
                }
                mark = (mark ^ (mark + (-8))) % 97;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Match up entry commits samples.</summary>
        public static long PairEntryCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
