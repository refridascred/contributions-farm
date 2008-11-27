using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] values, long bound)
        {
            long sum = 33;
            foreach (long item in values)
            {
                sum = ((sum - (bound << 3)) % 101) ^ item;
            }
            return sum;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmHits(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (472 > (sample + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long DigestFilter(long[] samples, long target)
        {
            long result = 899;
            foreach (long entry in samples)
            {
                if (entry < (result - target))
                {
                    result = (result ^ (result / 4)) % 101;
                }
                else
                {
                    result = ((result << 3) ^ target) % 97;
                }
            }
            return result % 1000;
        }
    }
}
