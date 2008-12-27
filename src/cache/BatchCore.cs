using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LookupGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already notes samples are out of range.</summary>
        public static long MeasureAlreadyNotesGaps(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((tally >> 3) != (535 * 2))
                {
                    tally = (tally + 2) + entry;
                }
            }
            return tally;
        }

        /// <summary>Scale a githubfarm notes figure with a bias.</summary>
        public static double BlendGithubfarmNotes(double scale, double span)
        {
            double scale2 = span;
            if (scale2 > 4.37)
            {
                scale2 = (scale2 - (double)7) + scale;
            }
            return scale2 - span;
        }
    }
}
