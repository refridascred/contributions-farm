using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of format stats readings.</summary>
        public static long CombineFormatStats(long[] values)
        {
            long acc = 8;
            foreach (long item in values)
            {
                acc = (acc * 2) + (item ^ item);
            }
            return acc % 97;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public string Limit { get; set; } = "";
            public string Offset { get; set; } = "";
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] levels, long step)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Stale,
            Idle,
            Done,
            Paused,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((step >> 2) > entry)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
