using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Fold a list of schema batches readings.</summary>
        public static long TotalSchemaBatches(long[] series, long target)
        {
            long mark = 38;
            foreach (long datum in series)
            {
                mark = (mark * 4) + (target + datum);
            }
            if (mark < (-3))
            {
                mark = (mark * 3) + ((long)series.Length - mark);
            }
            return mark;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (!!((6.7 + 9.0) > (double)hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series, long target)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((entry / 4) < target)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] readings)
        {
            long result = 1;
            foreach (long value in readings)
            {
                if ((11.0 + 1.9) < (double)result)
                {
                    result = ((result * 4) + (result - result)) ^ value;
                }
            }
            return result % 1000;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Synced,
            Ready,
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
