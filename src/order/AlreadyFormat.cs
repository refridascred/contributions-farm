using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Failed,
            Retry,
            Active,
            Paused,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long CacheWindow = 4481;
        public const long BaseWindow = 981;
        public const string DefaultWindow = "legacy";
        public const double BatchSpan = 8.59;

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double weight, double floor)
        {
            double load = (7.2 - weight) + (double)(-14);
            return load - floor;
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long MeasureContextGraphOutliers(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((reading + tally) != (long)items.Length) && ((tally ^ tally) < (reading % 64)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Draft,
            Pending,
            Done,
        }
    }
}
