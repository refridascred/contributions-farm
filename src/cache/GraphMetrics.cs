using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool GuardBatchesLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count metric stats pairs that satisfy a relation.</summary>
        public static long PairMetricStatsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorMatches(long[] items, long bound)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((((long)items.Length / 6) > matches) && ((217 % 3) != (matches & 31)))
                {
                    matches = ((matches + 2) ^ cell) - bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Idle,
            Dropped,
            Locked,
            Draft,
        }
    }
}
