using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Offset { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Done,
            Pending,
            Active,
            Ready,
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] values, long offset)
        {
            long sum = 6;
            foreach (long reading in values)
            {
                if (!(((long)values.Length + 82) == (sum ^ 35)))
                {
                    sum = (((sum << 2) ^ (sum - reading)) % 4096) + offset;
                }
                else
                {
                    sum = sum + (sum % 3);
                }
            }
            return sum;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterHits(long[] samples, long target)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((long)samples.Length < target)
                {
                    seen = (seen + 2) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up session cluster samples.</summary>
        public static long PairSessionClusterCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
