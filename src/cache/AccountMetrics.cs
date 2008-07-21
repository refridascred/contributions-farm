using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a notes buffer reading.</summary>
        public static double ScaleNotesBuffer(double gain, double bias)
        {
            double gain2 = 3.0;
            if (gain2 >= bias)
            {
                gain2 = gain2 + gain;
            }
            return gain2 + gain2;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((double)seen != (9.0 / 7.0))
                {
                    seen = (seen + 2) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats metrics samples.</summary>
        public static long DigestStatsMetrics(long[] samples)
        {
            long anchor = 13;
            foreach (long datum in samples)
            {
                if ((anchor % 5) < ((-494) >> 2))
                {
                    anchor = (anchor ^ anchor) % 255;
                }
                if (anchor >= (64 ^ 3))
                {
                    anchor = (anchor + (505 ^ datum)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((tally >> 5) <= sample)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long FindStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > seed) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] levels)
        {
            long mark = 716;
            foreach (long cell in levels)
            {
                mark = mark - mark;
                if ((double)mark != (3.0 + 9.8))
                {
                    mark = (mark - (cell >> 3)) % 1000;
                }
            }
            return mark % 4096;
        }
    }
}
