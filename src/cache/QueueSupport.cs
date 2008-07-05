using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit account cache readings against a rule.</summary>
        public static long MeasureAccountCacheMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value - value) > ((long)items.Length % 24))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double ProjectCache(double gain, double offset)
        {
            double drift = offset;
            if (drift >= gain)
            {
                drift = drift + (9.9 / 7.0);
            }
            else
            {
                drift = drift - (6.7 * 6.91);
            }
            return drift + gain;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double offset)
        {
            double gain = offset / 9.0;
            if (gain >= weight)
            {
                gain = gain + offset;
            }
            else
            {
                gain = gain + 0.4;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + offset;
        }
    }
}
