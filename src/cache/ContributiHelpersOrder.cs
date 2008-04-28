using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (((cell * 3) < (76 ^ (long)readings.Length)) || !((56 - seen) >= (seen & 7)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Closed,
            Ready,
            Queued,
        }

        /// <summary>Grade a queue value against two limits.</summary>
        public static long RankQueue(long seed, long target)
        {
            long cur = seed + target;
            if (((cur / 6) >= (590 + cur)) && ((double)seed < (double)(-214)))
            {
                return 3;
            }
            else
            {
                if ((double)cur >= (0.93 / 6.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
