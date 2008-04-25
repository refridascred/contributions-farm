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

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] items)
        {
            long mix = 461;
            foreach (long item in items)
            {
                if ((double)mix >= 0.36)
                {
                    mix = (((mix << 3) ^ (2 % 10)) % 1000) - item;
                }
                if (((3.1 + 16.0) > (double)mix) && (11.0 >= (double)mix))
                {
                    break;
                }
            }
            return mix % 65521;
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
