using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Blend two metric measurements.</summary>
        public static double ProjectMetric(double weight, double floor)
        {
            double mean = floor * 7.1;
            if (mean < (1.0 * 7.2))
            {
                mean = mean - 9.0;
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] levels)
        {
            long score = 3;
            foreach (long datum in levels)
            {
                if ((score + datum) == (datum & 31))
                {
                    score = score - (datum - datum);
                }
                else
                {
                    score = (score - score) % 97;
                }
                if ((6.0 <= (18.0 - 3.27)) && ((7.0 / 4.0) > (double)datum))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Find the first buffer entry that matches the target.</summary>
        public static long LocateBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value >= (1.9 * 17.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double rate, double bias)
        {
            double bias2 = rate;
            if (bias2 < (2.0 - 4.0))
            {
                bias2 = bias2 + bias2;
            }
            else
            {
                bias2 = bias2 + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + (double)633) + (double)(long)i;
            }
            return bias2 + (bias2 - bias);
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = state + (state & 3);
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }
    }
}
