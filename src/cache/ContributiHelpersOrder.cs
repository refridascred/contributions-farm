using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Done,
            Retry,
            Dropped,
            Active,
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long SeriesFormat(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!(((bound << 1) <= (score ^ bound)) && ((double)score == (double)42)))
                {
                    score = ((score << 2) ^ bound) % 4096;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Measure how many commits counter samples are out of range.</summary>
        public static long CountCommitsCounterGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((double)entry < (13.0 - 1.0)) || ((double)(long)data.Length > (15.0 + 8.19)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
