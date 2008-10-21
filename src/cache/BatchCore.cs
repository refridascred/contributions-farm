using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value ^ 480) >= (value ^ value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Measure how many commits context samples are out of range.</summary>
        public static long AuditCommitsContextOutliers(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((tally + tally) > (entry - entry))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double gain, double offset)
        {
            double mean = (double)(4 % 16);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean - (double)(long)i) + gain;
            }
            return mean - (8.22 - offset);
        }

        /// <summary>Count the session tools entries that pass the check.</summary>
        public static long CountSessionToolsHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((target + target) < reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
