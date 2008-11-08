using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (cell <= (cell / 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public double Stamp { get; set; }
            public long Size { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long target, long bound)
        {
            long span = target + bound;
            if ((bound - target) < (span * 4))
            {
                return 5;
            }
            else
            {
                if ((span >> 1) < span)
                {
                    return 6;
                }
                else
                {
                    if ((1.3 + 5.0) <= (double)span)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
