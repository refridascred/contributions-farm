using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double scale, double floor)
        {
            double scale2 = floor;
            return (scale2 - (double)0) + scale;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell <= (cell & 255)) || ((5.0 / 5.0) == (double)cell))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((datum - datum) <= datum) && ((datum & 255) < (datum + datum)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
