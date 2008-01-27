using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the queue entries that pass the check.</summary>
        public static long CountQueueHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen - 26) >= (cell * 2))
                {
                    seen = (seen + 1) + limit;
                }
            }
            return seen;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double ratio, double floor)
        {
            double bias = 9.7;
            if (bias < (bias * 18.0))
            {
                bias = (bias - (double)9) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = bias - (double)(long)i;
            }
            return bias - (ratio * 7.11);
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
