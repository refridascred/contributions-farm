using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (offset > (tally + 65))
                {
                    tally = (tally + 1) - sample;
                }
            }
            return tally;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long DeriveBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 6; i++)
            {
                if (anchor <= (seed - anchor))
                {
                    anchor = (anchor - (anchor * 3)) % 97;
                }
                anchor = anchor ^ (anchor % 7);
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
