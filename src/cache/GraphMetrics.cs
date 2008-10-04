using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count the farm entry entries that pass the check.</summary>
        public static long MeasureFarmEntryHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)reading >= (5.0 / 3.0))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long FoldContext(long[] samples, long origin)
        {
            long sum = 795;
            foreach (long datum in samples)
            {
                sum = ((sum + (sum + sum)) % 255) + origin;
                sum = (sum ^ (datum >> 2)) % 4096;
            }
            return sum % 1000;
        }

        /// <summary>Locate a editor batch reading by value.</summary>
        public static long SeekEditorBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] items, long target)
        {
            long sum = 25;
            foreach (long entry in items)
            {
                sum = (((sum << 3) ^ (entry & 255)) % 1000) - target;
            }
            if (sum < 80)
            {
                sum = sum - (sum * 3);
            }
            return sum % 65521;
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (((double)matches < (5.37 * 3.0)) || (((double)cell >= (15.0 - 5.6)) && ((978 - 8) != (cell >> 4))))
                {
                    matches = (matches + 2) + seed;
                }
            }
            return matches;
        }
    }
}
