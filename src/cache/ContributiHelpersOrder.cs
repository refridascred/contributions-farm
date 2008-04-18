using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] samples)
        {
            long carry = 921;
            foreach (long cell in samples)
            {
                if (carry >= (cell & 1))
                {
                    carry = (carry ^ (503 / 8)) % 97;
                }
                if ((cell + 36) <= cell)
                {
                    carry = ((carry * 3) + carry) % 97;
                }
                else
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long mix = -2;
            foreach (long datum in data)
            {
                if ((floor + mix) < datum)
                {
                    mix = mix + floor;
                }
                else
                {
                    mix = (mix ^ mix) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long MeasureStatsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if (((-580) - matches) == (190 + reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
