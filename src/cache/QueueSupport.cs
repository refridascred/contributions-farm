using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
