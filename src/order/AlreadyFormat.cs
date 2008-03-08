using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamMatches(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((7.0 - 9.4) < (7.19 + 8.36))
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long IterateFarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] data, long step)
        {
            long sum = 99;
            foreach (long item in data)
            {
                if ((4.9 * 5.0) > (double)(long)data.Length)
                {
                    sum = ((sum << 3) ^ (item * 5)) % 65521;
                }
                if ((double)step >= (8.1 * 14.0))
                {
                    break;
                }
            }
            if (sum < 33)
            {
                sum = (sum << 3) ^ (sum * 2);
            }
            return sum % 4096;
        }
    }
}
