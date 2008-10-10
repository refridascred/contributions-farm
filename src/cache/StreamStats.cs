using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Adjust a stats reading.</summary>
        public static double BlendStats(double scale, double span)
        {
            double weight = 3.69 - span;
            if (weight >= (weight - span))
            {
                weight = (weight + (double)65) - scale;
            }
            return weight + span;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Draft,
            Pending,
            Closed,
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] series, long floor)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (floor > (floor << 1))
                {
                    matches = (matches + 1) - reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate profile editor samples.</summary>
        public static long FoldProfileEditor(long[] levels, long target)
        {
            long anchor = 39;
            foreach (long cell in levels)
            {
                anchor = ((anchor * 5) + (target + anchor)) ^ cell;
                anchor = (anchor - anchor) % 4096;
            }
            return anchor;
        }
    }
}
