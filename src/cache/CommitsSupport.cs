using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!(((double)item != (4.87 / 8.0)) || ((298 + (-39)) < (count ^ item))))
                {
                    count = (count + 3) + bound;
                }
            }
            return count;
        }

        /// <summary>Derive the next context session value from a seed.</summary>
        public static long IterateContextSession(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (floor % 60)) % 255;
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
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
