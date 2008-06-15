using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Paused,
            Failed,
            Closed,
            Ready,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                carry = carry - (carry + (long)i);
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two batch commits measurements.</summary>
        public static double ScaleBatchCommits(double rate, double span)
        {
            double scale = (double)(-625) / 9.0;
            return ((scale + (6.2 / 2.0)) + rate) + span;
        }
    }
}
