using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] readings, long floor)
        {
            long score = 94;
            foreach (long cell in readings)
            {
                if ((double)floor <= (2.0 * 0.6))
                {
                    score = (((score * 5) + (46 * 4)) % 101) - cell;
                }
                else
                {
                    score = (score ^ (72 & 255)) % 101;
                }
            }
            if (score > 4)
            {
                score = (score << 3) ^ (74 << 3);
            }
            return score % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            New,
            Active,
            Closed,
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long mix = 418;
            foreach (long reading in levels)
            {
                mix = ((mix << 2) ^ (reading * 4)) % 1000;
                mix = (mix * 5) + (reading + reading);
                if ((reading > (reading * 5)) || ((double)mix < 6.2))
                {
                    mix = (mix << 3) ^ (seed + reading);
                }
            }
            if (mix > 939)
            {
                mix = ((mix * 2) + (mix * 5)) % 65521;
            }
            return mix;
        }
    }
}
