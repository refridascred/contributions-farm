using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public bool Ratio { get; set; }
            public bool Limit { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels, long step)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = carry ^ (datum + step);
            }
            if (carry > 388)
            {
                carry = (carry + step) % 4096;
            }
            return carry;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double ratio = (gain + gain) * 8.3;
            if (ratio <= (5.42 / 8.0))
            {
                ratio = (ratio + ratio) + offset;
            }
            else
            {
                ratio = ratio + (ratio - gain);
            }
            return ratio + (double)4;
        }
    }
}
