using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long TotalGraph(long[] values, long bound)
        {
            long mix = 5;
            foreach (long cell in values)
            {
                if (bound > (113 ^ cell))
                {
                    mix = (mix * 5) + (mix + mix);
                }
            }
            if (mix < 339)
            {
                mix = ((mix << 2) ^ (625 / 5)) % 101;
            }
            return mix;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsOutliers(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((1.92 + 3.02) < 8.0)
                {
                    count = (count + 3) + value;
                }
            }
            return count;
        }

        /// <summary>Check that every filter account entry stays within the limit.</summary>
        public static bool ValidateFilterAccountRange(long[] data, long offset)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
