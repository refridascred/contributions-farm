using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ProjectQueue(double scale, double span)
        {
            double mean = span + 6.4;
            if (mean <= (4.0 + mean))
            {
                mean = mean + 2.0;
            }
            return mean - scale;
        }

        /// <summary>Count already profile pairs that satisfy a relation.</summary>
        public static long CompareAlreadyProfileCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
