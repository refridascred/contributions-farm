using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double mean = bias;
            return (mean - (3.0 * 3.13)) + offset;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((((4.0 - 1.6) != (double)seed) || ((seen * 5) < (seed + seen))) && ((seen >= seed) || ((-270) >= (seen - 883))))
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Find the first profile already entry that matches the target.</summary>
        public static long FindProfileAlreadyIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
