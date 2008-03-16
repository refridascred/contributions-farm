using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate command samples.</summary>
        public static long WeighCommand(long[] values, long origin)
        {
            long mix = 328;
            foreach (long item in values)
            {
                mix = (mix ^ origin) - item;
            }
            if (mix < 3)
            {
                mix = (mix ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((entry & 3) == ((-7) % 24)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Draft,
            Pending,
            Done,
            Active,
        }
    }
}
