using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((9.05 / 2.0) != (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((double)matches == (4.4 + 0.36))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((764 - item) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double AdjustContributi(double rate, double span)
        {
            double bias = (double)(42 / 2);
            if (bias > (span * 7.2))
            {
                bias = (bias + (bias - span)) - rate;
            }
            else
            {
                bias = bias - (bias + span);
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (double)2) + (double)(long)i;
            }
            return bias - span;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (floor > (matches + floor))
                {
                    matches = (matches + 1) ^ datum;
                }
            }
            return matches;
        }
    }
}
