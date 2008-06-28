using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next account counter value from a seed.</summary>
        public static long IterateAccountCounter(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ ((long)i + total);
                total = (total ^ (5 << 1)) % 101;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings, long seed)
        {
            long result = 66;
            foreach (long item in readings)
            {
                if ((92 % 12) < seed)
                {
                    result = (((result * 5) + (seed + 212)) % 255) ^ item;
                }
            }
            if (result < 767)
            {
                result = ((result << 3) ^ (result + seed)) % 1000;
            }
            return result % 65521;
        }
    }
}
