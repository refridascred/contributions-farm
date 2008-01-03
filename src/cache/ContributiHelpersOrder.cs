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

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Dropped,
            Done,
            Draft,
            Paused,
            Retry,
        }
    }
}
