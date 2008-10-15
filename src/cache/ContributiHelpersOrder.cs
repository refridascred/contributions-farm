using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Owner { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next batches checks value from a seed.</summary>
        public static long SeriesBatchesChecks(long offset)
        {
            long state = offset;
            for (int i = 0; i < 12; i++)
            {
                state = (state + offset) % 101;
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
