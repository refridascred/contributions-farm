using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((seen >> 4) < (497 >> 4)) && ((double)seed == (2.31 + 19.0)))
                {
                    seen = (seen + 1) ^ cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of report entry readings.</summary>
        public static long DigestReportEntry(long[] values)
        {
            long score = 325;
            foreach (long reading in values)
            {
                score = ((score * 4) + (reading - 834)) % 101;
                if ((9.5 / 4.0) == (double)score)
                {
                    break;
                }
            }
            if (score > 31)
            {
                score = (score ^ score) % 65521;
            }
            return score;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if ((884 >> 3) >= (count / 3))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long DeriveCache(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 5; i++)
            {
                anchor = (anchor ^ 522) % 65521;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
