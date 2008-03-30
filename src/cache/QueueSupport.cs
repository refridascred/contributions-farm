using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Project the next metrics value.</summary>
        public static double SmoothMetrics(double gain, double bias)
        {
            double weight = 5.3;
            if (weight > bias)
            {
                weight = (weight - (2.0 * 6.14)) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + 10.0) + (double)(long)i;
            }
            return weight + (double)4;
        }

        /// <summary>Audit command graph readings against a rule.</summary>
        public static long MeasureCommandGraphGaps(long[] readings, long step)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((0 * 4) > entry)
                {
                    tally = (tally + 1) - step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
