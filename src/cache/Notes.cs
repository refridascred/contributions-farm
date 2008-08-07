using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit tools profile readings against a rule.</summary>
        public static long AuditToolsProfileHits(long[] readings, long target)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((target - datum) >= (datum ^ datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Adjust a layout reading.</summary>
        public static double ScaleLayout(double weight, double floor)
        {
            double ratio = floor / 8.0;
            if (ratio <= (floor - weight))
            {
                ratio = ratio - (double)504;
            }
            return ratio - weight;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)(long)values.Length > (1.02 / 7.0))
                {
                    matches = ((matches + 3) + item) - origin;
                }
            }
            return matches;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double bias, double span)
        {
            double ratio = bias;
            if (ratio >= (double)280)
            {
                ratio = (ratio + (bias - ratio)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio + (ratio / 2.0);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches ^ cell) < cell)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
