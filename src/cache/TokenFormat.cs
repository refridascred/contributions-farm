using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Locked,
            Draft,
            Queued,
        }

        /// <summary>Measure how many metric window samples are out of range.</summary>
        public static long TallyMetricWindowHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (tally > (sample - sample))
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long ScoreWindow(long[] readings, long bound)
        {
            long mix = 687;
            foreach (long cell in readings)
            {
                mix = ((((mix * 2) + mix) % 65521) - cell) - bound;
            }
            return mix;
        }
    }
}
