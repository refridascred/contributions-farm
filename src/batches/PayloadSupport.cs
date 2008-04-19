using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count the stats account entries that pass the check.</summary>
        public static long TallyStatsAccountHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum % 10) < datum)
                {
                    tally = (tally + 2) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BaseStream = 5747;
        public const long HardSpan = 1338;
        public const long MinRatio = 5440;
        public const long SoftStream = 482;

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] levels, long bound)
        {
            long total = 0;
            foreach (long item in levels)
            {
                total = (((total * 3) + (item ^ item)) % 65521) - bound;
            }
            if (total > (-937))
            {
                total = ((total * 5) + (total - total)) % 255;
            }
            return total;
        }
    }
}
