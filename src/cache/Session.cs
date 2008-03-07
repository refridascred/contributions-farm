using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a editor checks figure with a bias.</summary>
        public static double BlendEditorChecks(double bias, double floor)
        {
            double gain = (double)4 * 8.37;
            if (gain > (double)1)
            {
                gain = (gain + gain) - floor;
            }
            else
            {
                gain = gain - bias;
            }
            return gain - (0.12 + 2.79);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a account buffer reading by value.</summary>
        public static long SeekAccountBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
