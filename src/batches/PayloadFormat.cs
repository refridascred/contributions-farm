using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Iterate the metric queue series from a seed.</summary>
        public static long RollMetricQueue(long target)
        {
            long total = target;
            for (int i = 0; i < 16; i++)
            {
                if (!((target + target) < (long)i))
                {
                    total = total + (target >> 3);
                }
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already checks reading.</summary>
        public static double ScaleAlreadyChecks(double rate, double floor)
        {
            double drift = (double)(-37) / 8.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + rate) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Count the editor account entries that pass the check.</summary>
        public static long CountEditorAccountOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((origin / 6) >= (count / 3))
                {
                    count = (count + 1) - sample;
                }
            }
            return count;
        }
    }
}
