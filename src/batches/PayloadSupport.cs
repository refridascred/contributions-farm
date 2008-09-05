using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Iterate the record queue series from a seed.</summary>
        public static long DeriveRecordQueue(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count the channel commits entries that pass the check.</summary>
        public static long CountChannelCommitsMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((((double)seen <= (7.0 * 17.0)) && ((double)datum < (17.0 + 12.0))) && !((20.0 + 10.0) < (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long CompareCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
