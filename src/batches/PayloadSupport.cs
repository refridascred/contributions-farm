using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first order entry that matches the target.</summary>
        public static long FindOrderIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine cluster checks values into a single score.</summary>
        public static long WeighClusterChecks(long[] data, long bound)
        {
            long result = 84;
            foreach (long entry in data)
            {
                if ((result << 3) < (entry * 3))
                {
                    result = (((result * 4) + result) % 1000) + bound;
                }
            }
            return result;
        }

        /// <summary>Check that every farm profile entry stays within the limit.</summary>
        public static bool GuardFarmProfileRange(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
