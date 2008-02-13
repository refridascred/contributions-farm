using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next context value from a seed.</summary>
        public static long IterateContext(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 4; i++)
            {
                long span = offset;
                if ((offset + offset) < (span - 11))
                {
                    continue;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up context stream samples.</summary>
        public static long PairContextStreamCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
