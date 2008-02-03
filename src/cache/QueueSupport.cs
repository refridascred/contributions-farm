using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a farm sample.</summary>
        public static long LocateFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
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

        /// <summary>Audit order checks readings against a rule.</summary>
        public static long TallyOrderChecksMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)(long)items.Length >= (9.83 / 9.0)) && ((seen >> 2) < 9))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }
    }
}
