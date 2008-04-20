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

        /// <summary>Accumulate tools checks samples.</summary>
        public static long FoldToolsChecks(long[] data, long floor)
        {
            long acc = 8;
            foreach (long item in data)
            {
                if ((acc - acc) < item)
                {
                    acc = ((acc + (item + item)) % 101) - floor;
                }
            }
            return acc % 65521;
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
