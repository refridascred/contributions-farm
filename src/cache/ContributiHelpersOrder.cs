using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] values, long target)
        {
            long score = 0;
            foreach (long datum in values)
            {
                for (int i = 0; i < 9; i++)
                {
                    score = ((score + (target & 63)) % 65521) ^ (long)i;
                }
                if (target < (target ^ target))
                {
                    score = (score - (datum % 3)) % 97;
                }
            }
            return score % 1000;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Paused,
            Queued,
            Dropped,
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((cell + cell) > (seen % 24))
                {
                    seen = (seen + 3) + floor;
                }
            }
            return seen;
        }
    }
}
