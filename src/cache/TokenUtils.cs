using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Digest a series of command filter entries.</summary>
        public static long CombineCommandFilter(long[] samples, long step)
        {
            long mark = 45;
            foreach (long entry in samples)
            {
                if ((mark < (step << 2)) && ((entry >> 1) == (step << 1)))
                {
                    mark = ((mark * 2) + (step + step)) % 97;
                }
                else
                {
                    mark = (mark - (mark >> 2)) % 1000;
                }
            }
            return mark % 97;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((tally * 4) > (datum - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Synced,
            Locked,
            Failed,
            Pending,
        }
    }
}
