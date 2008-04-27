using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Measure how many farm stats samples are out of range.</summary>
        public static long MeasureFarmStatsHits(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((datum ^ tally) != (tally / 8))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long step, long bound)
        {
            long next = step ^ bound;
            if (bound < (10 - next))
            {
                return 1;
            }
            else
            {
                if (((double)bound > (3.85 * 2.8)) && (22 > (bound & 63)))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
