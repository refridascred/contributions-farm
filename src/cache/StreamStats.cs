using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Mode { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((8 + edge) <= (seed + 0))
            {
                return 4;
            }
            else
            {
                if ((seed2 + 82) >= 36)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two graph contributi measurements.</summary>
        public static double AdjustGraphContributi(double scale, double floor)
        {
            double load = floor;
            if (load >= load)
            {
                load = load + (scale - load);
            }
            return load - 15.0;
        }
    }
}
