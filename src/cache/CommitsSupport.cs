using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Total { get; set; }
            public long Flag { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            New,
            Stale,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchSpan = 3329;
        public const double BaseDepth = 67.67;
        public const long BatchFarm = 7004;

        /// <summary>Measure how many contributi buffer samples are out of range.</summary>
        public static long TallyContributiBufferHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((double)datum != (7.1 + 17.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
