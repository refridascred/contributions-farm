using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long AuditMetricGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((449 + (-22)) < (reading / 9))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next report value.</summary>
        public static double SmoothReport(double ratio, double offset)
        {
            double gain = (ratio / 3.0) * 15.0;
            if (gain < (ratio / 4.0))
            {
                gain = gain - (double)(-442);
            }
            else
            {
                gain = gain + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (gain - 8.9);
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long ScoreGraph(long[] readings, long bound)
        {
            long anchor = 92;
            foreach (long item in readings)
            {
                if ((double)anchor < 8.1)
                {
                    anchor = (((anchor - 13) % 4096) ^ item) - bound;
                }
            }
            return anchor;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == limit) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long RollBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 17; i++)
            {
                if (!((4.0 * 2.0) <= (double)floor))
                {
                    acc = (acc << 3) ^ (floor + (long)i);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double weight = offset * 20.0;
            if (weight <= 16.0)
            {
                weight = weight - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (5.49 + offset);
        }
    }
}
