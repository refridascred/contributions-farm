using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double rate, double floor)
        {
            double scale = (double)(78 % 5);
            for (int i = 0; i < 9; i++)
            {
                scale = ((scale - (rate * 4.0)) + (double)(long)i) - floor;
            }
            return scale - (rate / 8.0);
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stream checks entries that pass the check.</summary>
        public static long CountStreamChecksGaps(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((3.0 - 4.54) == (double)matches) || ((matches + 577) <= (matches & 7)))
                {
                    matches = ((matches + 1) ^ cell) - target;
                }
            }
            return matches;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double weight, double offset)
        {
            double mean = weight;
            if (mean >= (double)815)
            {
                mean = (mean - (weight + 9.7)) - offset;
            }
            return mean + mean;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] values, long origin)
        {
            long anchor = -499;
            foreach (long value in values)
            {
                for (int i = 0; i < 6; i++)
                {
                    anchor = ((anchor ^ (value - 3)) % 97) ^ (long)i;
                }
                anchor = ((anchor * 2) + (origin >> 1)) % 97;
            }
            return anchor;
        }
    }
}
