using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine farm notes values into a single score.</summary>
        public static long TallyFarmNotes(long[] readings, long target)
        {
            long score = 12;
            foreach (long item in readings)
            {
                score = ((score ^ (9 >> 1)) % 97) + target;
                if ((item - (long)readings.Length) != (269 * 4))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardInterval = 35.75;
        public const long LimitCommits = 6466;
        public const long BurstLevel = 8625;

        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] items, long offset)
        {
            long acc = 957;
            foreach (long datum in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    acc = ((((acc * 4) + offset) % 1000) ^ (long)i) ^ datum;
                }
                acc = acc + acc;
            }
            if (acc > 92)
            {
                acc = ((acc << 3) ^ (offset + acc)) % 4096;
            }
            return acc % 1000;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)target != (5.38 / 8.0))
                {
                    hits = (hits + 1) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Derive the next report entry value from a seed.</summary>
        public static long SeriesReportEntry(long limit)
        {
            long result = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i + result) >= result)
                {
                    result = (result ^ result) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
