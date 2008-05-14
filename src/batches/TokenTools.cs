using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] items, long limit)
        {
            long mark = 4;
            foreach (long datum in items)
            {
                mark = ((mark ^ (54 >> 3)) ^ datum) - limit;
            }
            return mark % 4096;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally >= ((-4) + 962)) && ((double)tally > (0.08 + 19.0)))
                {
                    tally = ((tally + 2) + cell) - target;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
