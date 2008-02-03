using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a support buffer reading by value.</summary>
        public static long LookupSupportBufferIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double rate, double span)
        {
            double ratio = span;
            if (ratio < rate)
            {
                ratio = ratio + (9.06 * 8.7);
            }
            return ratio + (double)59;
        }

        /// <summary>Combine account record values into a single score.</summary>
        public static long TotalAccountRecord(long[] series, long target)
        {
            long carry = 701;
            foreach (long reading in series)
            {
                if (target >= ((-727) + target))
                {
                    carry = (carry ^ carry) + reading;
                }
                carry = (carry ^ (carry + 2)) % 1000;
            }
            return carry;
        }
    }
}
