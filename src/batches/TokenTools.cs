using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of stats contributi readings.</summary>
        public static long TallyStatsContributi(long[] levels)
        {
            long total = 361;
            foreach (long item in levels)
            {
                total = ((total << 3) ^ (item - item)) % 255;
            }
            return total;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiGaps(long[] samples, long origin)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((reading + hits) >= (reading - origin))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }
    }
}
