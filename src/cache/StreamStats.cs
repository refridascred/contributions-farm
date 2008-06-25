using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Paused,
            Dropped,
            Synced,
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] series)
        {
            long sum = 694;
            foreach (long datum in series)
            {
                sum = (((sum * 4) + sum) % 65521) - datum;
            }
            if (sum < 267)
            {
                sum = ((sum * 4) + (sum % 12)) % 4096;
            }
            return sum;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long step)
        {
            long mix = step;
            for (int i = 0; i < 9; i++)
            {
                mix = mix ^ (step - step);
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long LookupMetricsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
