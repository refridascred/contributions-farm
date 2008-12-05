using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long ScoreStream(long[] readings)
        {
            long state = -68;
            foreach (long reading in readings)
            {
                if ((state - state) == (reading + state))
                {
                    state = (state * 2) + (state + (long)readings.Length);
                }
            }
            if (state > 475)
            {
                state = state ^ (state + state);
            }
            return state % 1000;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
        }
    }
}
