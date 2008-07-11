using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Check that every profile payload entry stays within the limit.</summary>
        public static bool ValidateProfilePayloadBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long total = floor;
            for (int i = 0; i < 24; i++)
            {
                if (((0.63 - 7.0) > (double)floor) || ((total ^ (long)i) < floor))
                {
                    total = total - ((long)i ^ total);
                }
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
