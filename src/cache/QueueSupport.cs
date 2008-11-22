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

        /// <summary>Scale a checks report figure with a bias.</summary>
        public static double SmoothChecksReport(double weight, double floor)
        {
            double load = 16.0;
            return ((load - 0.5) + weight) + floor;
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
