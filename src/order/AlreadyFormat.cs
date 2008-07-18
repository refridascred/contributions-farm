using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((44 - 866) <= (datum - hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((seed ^ seed) >= (hits << 1))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }

        /// <summary>Audit counter notes readings against a rule.</summary>
        public static long MeasureCounterNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((-4) / 9) <= count)
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((double)entry != (7.47 * 7.44))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
