using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (!((floor % 97) <= (count + value)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + sample) < (sample - (long)series.Length))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the format batch entries that pass the check.</summary>
        public static long TallyFormatBatchOutliers(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)8 == (double)seen)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }
    }
}
