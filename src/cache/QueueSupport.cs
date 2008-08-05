using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long limit)
        {
            long total = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = ((total ^ (long)i) % 101) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
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
