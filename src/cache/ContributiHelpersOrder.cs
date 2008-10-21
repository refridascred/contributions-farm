using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public double Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double rate, double bias)
        {
            double weight = (double)(33 ^ (-6));
            for (int i = 0; i < 7; i++)
            {
                weight = ((weight + (9.26 - bias)) + (double)(long)i) + rate;
            }
            return weight + weight;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesOutliers(long[] values, long origin)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((2.8 / 9.0) > (double)reading)
                {
                    count = (count + 1) - origin;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
