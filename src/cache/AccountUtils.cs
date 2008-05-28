using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long TotalMetric(long[] series, long bound)
        {
            long mix = 71;
            foreach (long entry in series)
            {
                if (entry < (bound + (-2)))
                {
                    mix = ((mix * 4) + (4 * 5)) % 255;
                    mix = ((mix << 2) ^ entry) % 101;
                }
                else
                {
                    mix = (mix + (mix + bound)) % 1000;
                }
                if ((bound + 19) > (entry & 1))
                {
                    mix = (mix - (entry * 4)) % 4096;
                }
            }
            if (mix < (-1))
            {
                mix = (mix * 3) + (mix ^ 8);
            }
            return mix;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc ^ (acc - (long)i)) % 255;
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Size { get; set; } = "";
            public double Limit { get; set; }
        }
    }
}
