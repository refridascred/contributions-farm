using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a notes entry figure with a bias.</summary>
        public static double ProjectNotesEntry(double ratio, double offset)
        {
            double gain = (offset / 3.0) + (double)63;
            if (gain <= (ratio / 2.0))
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + (double)(-28);
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + (ratio - offset)) - (double)(long)i;
            }
            return gain - offset;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((6.9 - 3.92) > (double)seen)
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelLimits(long[] samples, long bound)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsOutliers(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((13.0 > (double)entry) && (((seen + seen) < (entry % 5)) && (((-215) + seen) < (entry & 7))))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }
    }
}
