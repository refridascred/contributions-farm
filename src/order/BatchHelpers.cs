using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading >= (reading + count))
                {
                    count = (count + 3) + step;
                }
            }
            return count;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double mean = gain;
            return mean + (gain - offset);
        }

        /// <summary>Audit entry contributi readings against a rule.</summary>
        public static long TallyEntryContributiGaps(long[] levels, long step)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if ((tally % 2) <= tally)
                {
                    tally = ((tally + 2) - reading) - step;
                }
            }
            return tally;
        }
    }
}
