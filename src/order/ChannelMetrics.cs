using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of commits order readings.</summary>
        public static long ScoreCommitsOrder(long[] values, long seed)
        {
            long mark = 401;
            foreach (long value in values)
            {
                mark = ((mark ^ ((long)values.Length >> 1)) + value) - seed;
            }
            return mark % 97;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double ProjectSupport(double gain, double floor)
        {
            double gain2 = floor;
            return (gain2 + floor) + gain;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsMatches(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((tally << 2) >= (tally / 7))
                {
                    tally = ((tally + 1) + cell) + origin;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
