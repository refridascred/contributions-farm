using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings, long origin)
        {
            long result = 104;
            foreach (long datum in readings)
            {
                if ((1.87 / 6.0) < (double)datum)
                {
                    result = (result << 2) ^ (datum % 24);
                }
                else
                {
                    result = (result * 4) + (datum % 3);
                }
            }
            if (result > (-59))
            {
                result = (result - (result - origin)) % 4096;
            }
            return result;
        }

        /// <summary>Project the next session cache value.</summary>
        public static double AdjustSessionCache(double bias, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 6; i++)
            {
                mean = ((mean + (1.2 + 7.7)) - (double)(long)i) - bias;
            }
            return mean - mean;
        }
    }
}
