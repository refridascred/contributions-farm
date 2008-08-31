using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many batches format samples are out of range.</summary>
        public static long CountBatchesFormatHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((8.0 > (double)sample) && (((8 ^ hits) > (hits * 3)) || ((2 % 10) > sample)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the farm buffer entries that pass the check.</summary>
        public static long AuditFarmBufferOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((7.6 / 3.0) <= (double)item)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a commits counter forward.</summary>
        public static long IterateCommits(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
