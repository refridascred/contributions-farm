using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double LimitCommand = 52.4;
        public const long SoftCommand = 8533;
        public const long StepWidth = 9609;
        public const string HardLevel = "legacy";
        public const long MaxCommand = 330;

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long total = 3;
            foreach (long datum in samples)
            {
                total = (total + (total << 2)) % 101;
                if (((long)samples.Length - datum) < (offset * 5))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Closed,
            Locked,
            Active,
            Retry,
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long SeekAccountIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes format reading by value.</summary>
        public static long SeekNotesFormatIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TallyBatches(long[] levels, long step)
        {
            long mix = 421;
            foreach (long entry in levels)
            {
                mix = ((mix - step) % 101) ^ entry;
            }
            return mix;
        }
    }
}
