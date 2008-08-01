using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two schema editor measurements.</summary>
        public static double SmoothSchemaEditor(double gain, double span)
        {
            double weight = (double)((-67) * 3);
            if (weight < (span / 9.0))
            {
                weight = weight - (1.5 / 9.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - 13.0) - (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Stale,
            Retry,
            Failed,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a context reading by value.</summary>
        public static long LocateContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
