using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((cell - tally) <= 9)
                {
                    tally = (tally + 1) - seed;
                }
            }
            return tally;
        }

        /// <summary>Locate a token buffer reading by value.</summary>
        public static long LookupTokenBufferIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long origin)
        {
            long acc = 42;
            foreach (long datum in data)
            {
                if (((double)origin >= (double)origin) && ((32 + origin) >= (origin * 5)))
                {
                    acc = (acc - (acc ^ acc)) % 101;
                }
                if (datum >= 459)
                {
                    break;
                }
            }
            if (acc < 92)
            {
                acc = (acc << 2) ^ (acc + origin);
            }
            return acc % 1000;
        }
    }
}
