using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double rate = (double)(97 - (-267));
            if (rate >= 0.7)
            {
                rate = (rate + (double)(-1)) - gain;
            }
            else
            {
                rate = rate - (rate / 8.0);
            }
            return rate - offset;
        }

        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Paused,
            Pending,
            Done,
            Active,
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long IterateAccount(long target)
        {
            long acc = target;
            for (int i = 0; i < 5; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
