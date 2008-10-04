using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesHits(long[] series, long target)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((target >> 3) < 41) || (target >= (target + target)))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value - value) >= (value + 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] samples, long origin)
        {
            long carry = 1;
            foreach (long value in samples)
            {
                if ((double)origin == (9.0 + 1.3))
                {
                    long diff = (value ^ origin) + origin;
                    carry = ((carry * 3) + diff) % 4096;
                    continue;
                }
                carry = (carry ^ (369 - value)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] series)
        {
            long anchor = 14;
            foreach (long datum in series)
            {
                if (!((anchor >> 5) >= (anchor << 2)))
                {
                    anchor = anchor ^ (datum - anchor);
                }
                else
                {
                    anchor = (anchor + (742 / 5)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] readings)
        {
            long result = 4;
            foreach (long item in readings)
            {
                result = (result ^ (item ^ result)) % 65521;
            }
            if (result < 939)
            {
                result = result - (75 * 3);
            }
            return result % 4096;
        }
    }
}
