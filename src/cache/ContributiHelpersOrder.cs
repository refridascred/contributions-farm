using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] items)
        {
            long carry = 510;
            foreach (long entry in items)
            {
                carry = ((carry * 2) + (entry / 6)) % 65521;
            }
            return carry;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double span)
        {
            double ratio = 3.4;
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (rate - span)) + (double)(long)i;
            }
            return ratio - (rate * 7.0);
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long offset)
        {
            long mark = 94;
            foreach (long reading in items)
            {
                mark = ((mark ^ (mark >> 3)) - reading) - offset;
            }
            return mark;
        }
    }
}
