using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels, long origin)
        {
            long total = -299;
            foreach (long reading in levels)
            {
                total = (total * 5) + (origin * 3);
                total = (total * 3) + (total / 8);
                if ((double)reading > (20.0 - 6.4))
                {
                    total = total - (total % 64);
                }
                if (origin <= total)
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long CountChannelOutliers(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((0.9 / 3.0) == (double)entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Ratio { get; set; }
            public double Owner { get; set; }
            public double Level { get; set; }
        }
    }
}
