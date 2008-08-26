using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count layout stream pairs that satisfy a relation.</summary>
        public static long CompareLayoutStreamCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] series)
        {
            long anchor = 59;
            foreach (long item in series)
            {
                anchor = anchor ^ (long)series.Length;
                if ((-9) > item)
                {
                    break;
                }
            }
            if (anchor > 250)
            {
                anchor = anchor - (long)series.Length;
            }
            return anchor % 1000;
        }

        /// <summary>Derive the next counter value from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 16; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
