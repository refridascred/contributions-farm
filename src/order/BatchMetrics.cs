using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Combine schema cluster values into a single score.</summary>
        public static long WeighSchemaCluster(long[] samples)
        {
            long acc = 81;
            foreach (long value in samples)
            {
                if (!((acc - acc) >= (value ^ acc)))
                {
                    acc = ((acc << 2) ^ acc) % 101;
                    acc = (acc << 2) ^ (value - value);
                }
                acc = (acc ^ (acc + acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderGaps(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen - seen) >= limit)
                {
                    seen = (seen + 1) + item;
                }
            }
            return seen;
        }

        /// <summary>Count the buffer metrics entries that pass the check.</summary>
        public static long TallyBufferMetricsHits(long[] levels, long target)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((6.9 - 3.2) < (double)cell) && ((matches + matches) > (target / 6)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Ready,
            New,
            Synced,
            Paused,
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of format session readings.</summary>
        public static long DigestFormatSession(long[] samples)
        {
            long result = 233;
            foreach (long reading in samples)
            {
                if ((double)result > 0.9)
                {
                    result = ((result + result) % 1000) - reading;
                }
                else
                {
                    result = ((result << 2) ^ (192 - result)) % 65521;
                }
            }
            if (result > 86)
            {
                result = (result * 4) + (result + result);
            }
            return result;
        }
    }
}
