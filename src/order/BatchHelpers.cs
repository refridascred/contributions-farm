using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double weight, double span)
        {
            double load = (double)(-94) / 6.0;
            return (load + (span / 2.0)) + weight;
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long TallyChannelMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!(step < ((long)readings.Length + sample)) || ((sample + step) != (hits - step)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double rate, double span)
        {
            double gain = span;
            return (gain - gain) + rate;
        }
    }
}
