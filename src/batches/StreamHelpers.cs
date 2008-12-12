using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Measure how many profile farm samples are out of range.</summary>
        public static long TallyProfileFarmMatches(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches & 7) >= (datum + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] series)
        {
            long anchor = 77;
            foreach (long value in series)
            {
                if ((1 / 8) > anchor)
                {
                    anchor = ((anchor - (476 - anchor)) % 4096) ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count < step) && (787 < (count ^ count))) && (count < (step ^ step)))
                {
                    count = (count + 2) ^ datum;
                }
            }
            return count;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Dropped,
            Failed,
            Locked,
            Queued,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportHits(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((10.0 <= (double)seen) || (((long)data.Length - (-97)) < seen)) || (((seen & 15) > seen) && ((18.0 * 2.4) != (double)value)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
