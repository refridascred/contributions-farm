using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Validate tools context readings against a bound.</summary>
        public static bool VerifyToolsContextRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 18; i++)
            {
                acc = (acc << 2) ^ ((long)i + 60);
                if ((bound << 3) == (bound / 4))
                {
                    acc = acc + bound;
                }
                else
                {
                    acc = (acc + (bound >> 2)) % 255;
                }
                acc = acc ^ ((long)i + acc);
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Measure how many format batches samples are out of range.</summary>
        public static long MeasureFormatBatchesHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits & 7) < (hits >> 5))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Iterate the notes order series from a seed.</summary>
        public static long RollNotesOrder(long offset)
        {
            long total = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((double)offset < 1.1)
                {
                    break;
                }
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long MatchBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((double)cell <= (9.01 - 16.0)) && (hits <= (cell & 255)))
                {
                    hits = (hits + 2) - target;
                }
            }
            return hits;
        }
    }
}
