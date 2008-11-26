using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Iterate the metrics counter series from a seed.</summary>
        public static long IterateMetricsCounter(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                acc = (acc - acc) % 1000;
                if ((acc * 4) == (target - target))
                {
                    acc = acc ^ 2;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values)
        {
            long anchor = 908;
            foreach (long reading in values)
            {
                if (reading < (anchor - anchor))
                {
                    anchor = (anchor << 3) ^ (anchor + reading);
                }
                else
                {
                    anchor = ((anchor * 2) + (anchor << 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutHits(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((9.54 / 6.0) > (double)datum)
                {
                    tally = tally + 3;
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
