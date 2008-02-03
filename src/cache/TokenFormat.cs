using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (((tally < datum) || ((double)datum >= (double)1)) || (37 >= (tally - datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Stamp { get; set; }
            public double Token { get; set; }
            public double Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Combine contributi metrics values into a single score.</summary>
        public static long FoldContributiMetrics(long[] values, long target)
        {
            long score = 21;
            foreach (long reading in values)
            {
                if ((target ^ reading) > (reading ^ reading))
                {
                    score = ((score * 4) + (reading + score)) % 65521;
                }
                else
                {
                    score = (score << 2) ^ (target % 7);
                }
                if ((reading > (reading + score)) && ((11.0 * 2.0) < (double)reading))
                {
                    break;
                }
            }
            return score;
        }
    }
}
