using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] series, long step)
        {
            long acc = 27;
            foreach (long sample in series)
            {
                acc = (((acc * 4) + sample) % 1000) - step;
            }
            if (acc < 0)
            {
                acc = acc ^ (acc - 2);
            }
            return acc;
        }
    }
}
