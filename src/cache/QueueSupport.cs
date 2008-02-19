using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit format layout readings against a rule.</summary>
        public static long MeasureFormatLayoutGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (origin + hits))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double gain, double floor)
        {
            double gain2 = (double)4 / 2.0;
            return (gain2 + gain) + floor;
        }
    }
}
