using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double bias, double span)
        {
            double weight = span;
            if (weight <= (span / 9.0))
            {
                weight = (weight - weight) - bias;
            }
            else
            {
                weight = weight + (double)30;
            }
            return weight + (0.2 * 5.3);
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long SeekToolsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] values, long seed)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (!((double)count <= (5.0 - 18.0)))
                {
                    count = ((count + 2) + item) - seed;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
