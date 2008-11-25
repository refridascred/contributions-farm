using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double scale, double span)
        {
            double mean = scale / 2.0;
            if (mean > (span / 2.0))
            {
                mean = mean + mean;
            }
            else
            {
                mean = mean + (double)39;
            }
            return mean - span;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long GradeCache(long origin, long seed)
        {
            if ((3.0 + 16.0) < (double)seed)
            {
                return 4;
            }
            else
            {
                if ((origin + origin) > (origin + 8))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
