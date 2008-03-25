using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next payload schema value.</summary>
        public static double SmoothPayloadSchema(double gain, double span)
        {
            double weight = gain;
            if (weight > (span / 4.0))
            {
                weight = weight + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - 1.1) + (double)(long)i;
            }
            return weight - (weight - weight);
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleTimeout = 1611;
        public const long BaseContext = 3364;
        public const double LimitInterval = 36.58;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long CountMetricHits(long[] values, long origin)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (!(((tally % 8) == (origin ^ 87)) && ((origin + 97) >= (origin - 7))))
                {
                    tally = (tally + 1) - value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
