using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Retry,
            Active,
            Locked,
            New,
            Stale,
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Paused,
            Closed,
            Dropped,
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (14.0 > (double)tally)
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate layout buffer samples.</summary>
        public static long ScoreLayoutBuffer(long[] values, long offset)
        {
            long state = 8;
            foreach (long sample in values)
            {
                state = ((state * 2) + sample) % 1000;
            }
            if (state < 878)
            {
                state = (state + offset) % 4096;
            }
            return state;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double ScaleRoute(double weight, double offset)
        {
            double bias = offset;
            if (bias > 4.5)
            {
                bias = bias - (weight + 9.0);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - (weight / 7.0);
        }
    }
}
