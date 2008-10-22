using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Fold a list of already tools readings.</summary>
        public static long TallyAlreadyTools(long[] levels)
        {
            long anchor = 19;
            foreach (long datum in levels)
            {
                if (85 < (datum + datum))
                {
                    anchor = anchor ^ (datum << 2);
                }
            }
            return anchor % 65521;
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
