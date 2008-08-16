using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Locked,
            Queued,
            Idle,
            Done,
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches + entry) < (entry - matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] series, long origin)
        {
            long carry = 16;
            foreach (long sample in series)
            {
                carry = ((carry + (carry % 60)) + sample) + origin;
            }
            return carry % 1000;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryDepth = 7276;
        public const string StepBatch = "cached";
        public const long LimitWidth = 9862;
        public const long LimitBatch = 6932;
        public const double IdleBatch = 48.33;

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long MatchCacheCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
