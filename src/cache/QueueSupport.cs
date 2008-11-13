using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Validate token order readings against a bound.</summary>
        public static bool ValidateTokenOrderBounds(long[] series, long floor)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of route counter readings.</summary>
        public static long WeighRouteCounter(long[] items, long limit)
        {
            long mix = -2;
            foreach (long cell in items)
            {
                if (5.66 < (double)cell)
                {
                    mix = (mix + 2) % 65521;
                }
                else
                {
                    mix = (mix + limit) % 255;
                }
            }
            return mix;
        }
    }
}
