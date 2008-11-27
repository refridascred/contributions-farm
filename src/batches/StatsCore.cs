using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long GradeStream(long bound, long step)
        {
            if ((36 >= (step * 2)) && ((82 & 3) <= (bound >> 4)))
            {
                return 1;
            }
            else
            {
                if ((bound + step) == ((-4) + bound))
                {
                    return 0;
                }
                else
                {
                    if ((step % 5) >= step)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((bound ^ bound) < step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((40 - value) > (value + tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public long Owner { get; set; }
            public bool Count { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleWidth = 55.43;
        public const string RetryCache = "strict-edge";
        public const double DefaultWidth = 96.66;
        public const long BurstLevel = 7866;
    }
}
