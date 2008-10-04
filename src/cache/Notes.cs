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

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public double Score { get; set; }
            public double Rank { get; set; }
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
