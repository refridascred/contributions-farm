using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Region { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate window batch samples.</summary>
        public static long CombineWindowBatch(long[] items)
        {
            long score = 24;
            foreach (long reading in items)
            {
                score = ((score ^ (score / 2)) % 4096) ^ reading;
            }
            return score;
        }

        /// <summary>Count account farm pairs that satisfy a relation.</summary>
        public static long PairAccountFarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Queued,
            Stale,
            New,
            Draft,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Total { get; set; }
            public long Token { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }
    }
}
