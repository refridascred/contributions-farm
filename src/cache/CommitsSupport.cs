using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Owner { get; set; }
            public long Region { get; set; }
            public bool Offset { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Draft,
            Idle,
            New,
            Ready,
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountGaps(long[] values, long offset)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if (matches > (offset + matches))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Owner { get; set; }
            public double Mode { get; set; }
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long StepEntry(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 11; i++)
            {
                anchor = anchor ^ (seed ^ anchor);
                anchor = anchor - 740;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
