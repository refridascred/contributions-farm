using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series)
        {
            long state = 287;
            foreach (long cell in series)
            {
                state = (state ^ (cell + state)) % 255;
            }
            return state;
        }
    }
}
