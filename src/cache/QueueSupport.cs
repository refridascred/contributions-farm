using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double load = bias / 4.0;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (1.1 * 2.64)) + (double)(long)i) - floor;
            }
            return load - load;
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
