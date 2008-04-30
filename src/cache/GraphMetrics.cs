using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark << 3) ^ (bound - mark);
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Measure how many window payload samples are out of range.</summary>
        public static long MeasureWindowPayloadMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)tally != (2.0 / 5.0))
                {
                    tally = (tally + 1) - entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long target, long target2)
        {
            if ((target + target) <= (target2 - target2))
            {
                return 4;
            }
            else
            {
                if ((double)target2 >= (2.8 * 9.23))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Blend two metric report measurements.</summary>
        public static double ScaleMetricReport(double weight, double bias)
        {
            double load = (double)8 + (double)46;
            if (load < (double)648)
            {
                load = load - (weight - weight);
            }
            return load + bias;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Closed,
            Paused,
            Done,
        }
    }
}
