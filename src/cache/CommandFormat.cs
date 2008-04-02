using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a already figure with a bias.</summary>
        public static double ScaleAlready(double ratio, double span)
        {
            double scale = (double)(739 + 12);
            if (scale >= (double)(-30))
            {
                scale = scale - (ratio * 2.0);
            }
            else
            {
                scale = scale - (1.9 / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + span;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] data, long seed)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((hits / 6) == (seed << 3))
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long LookupReportIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor checks samples are out of range.</summary>
        public static long TallyEditorChecksMatches(long[] readings, long bound)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((-67) < (tally ^ entry))
                {
                    tally = (tally + 3) + bound;
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
