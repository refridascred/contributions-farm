using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a metric checks figure with a bias.</summary>
        public static double ScaleMetricChecks(double rate, double span)
        {
            double ratio = (double)(157 - 220);
            if (ratio > ratio)
            {
                ratio = (ratio - (double)42) - rate;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - span) - (double)(long)i;
            }
            return ratio + span;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches * 4) == (entry + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count the context farm entries that pass the check.</summary>
        public static long CountContextFarmHits(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally + tally) != (value ^ 73))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long AuditStreamHits(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item - item) > item)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the metric layout series from a seed.</summary>
        public static long StepMetricLayout(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
