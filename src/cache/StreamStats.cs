using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Idle,
            Closed,
            Done,
        }

        /// <summary>Fold a list of already record readings.</summary>
        public static long TallyAlreadyRecord(long[] levels)
        {
            long result = 9;
            foreach (long entry in levels)
            {
                result = result - entry;
                if ((result + entry) == (entry * 3))
                {
                    result = (result ^ 55) % 65521;
                }
                if ((double)entry > (double)result)
                {
                    result = (result ^ (entry + 72)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long offset, long seed)
        {
            if ((seed + offset) >= (offset ^ offset))
            {
                return 6;
            }
            else
            {
                if (((4 * 3) <= (offset << 1)) || ((seed - 6) >= (seed / 2)))
                {
                    return 7;
                }
                else
                {
                    if ((seed + offset) == (offset / 9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double ProjectCommits(double ratio, double bias)
        {
            double load = (ratio / 4.0) + ratio;
            return load - bias;
        }
    }
}
