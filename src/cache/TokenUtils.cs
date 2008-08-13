using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Failed,
            Active,
            Synced,
            Ready,
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
