using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (bound >= matches)
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((entry * 4) != (entry ^ entry)) && (((long)levels.Length & 7) < tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double scale, double offset)
        {
            double ratio = (double)12 / 7.0;
            return (ratio + (offset * 10.0)) + scale;
        }
    }
}
