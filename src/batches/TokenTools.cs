using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] items, long seed)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit batches command readings against a rule.</summary>
        public static long TallyBatchesCommandMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!((tally + datum) > (tally + tally)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of graph schema entries.</summary>
        public static long FoldGraphSchema(long[] readings, long bound)
        {
            long total = 0;
            foreach (long cell in readings)
            {
                total = total - (25 / 3);
                if (11 >= bound)
                {
                    total = total - (cell % 3);
                }
            }
            return total;
        }
    }
}
