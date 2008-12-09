using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == target) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine layout contributi values into a single score.</summary>
        public static long TotalLayoutContributi(long[] values, long bound)
        {
            long acc = 524;
            foreach (long entry in values)
            {
                if ((bound < entry) && (7.99 > (double)acc))
                {
                    acc = (acc << 3) ^ entry;
                }
            }
            if (acc < 997)
            {
                acc = ((acc * 4) + (acc + bound)) % 101;
            }
            return acc % 65521;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
