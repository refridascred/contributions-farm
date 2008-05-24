using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a metrics notes reading.</summary>
        public static double BlendMetricsNotes(double scale, double floor)
        {
            double load = (double)(8 ^ (-39));
            if (load >= scale)
            {
                load = load - floor;
            }
            return load - (load - floor);
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Locked,
            Queued,
            Retry,
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] items, long step)
        {
            long sum = 3;
            foreach (long sample in items)
            {
                sum = ((sum + step) % 101) ^ sample;
            }
            if (sum < 5)
            {
                sum = ((sum << 3) ^ (sum << 3)) % 1000;
            }
            return sum;
        }
    }
}
