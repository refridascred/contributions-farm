using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Roll a command record counter forward.</summary>
        public static long StepCommandRecord(long limit)
        {
            long total = limit;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double scale = 6.23;
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale + (offset - scale);
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterGaps(long[] values, long seed)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((double)sample != (3.08 * 2.4))
                {
                    tally = (tally + 2) + seed;
                }
            }
            return tally;
        }
    }
}
