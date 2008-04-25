using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == origin) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            New,
            Closed,
            Pending,
            Dropped,
            Paused,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long floor)
        {
            long total = floor;
            for (int i = 0; i < 14; i++)
            {
                total = (total ^ floor) % 1000;
                total = (total + (total % 24)) % 101;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
