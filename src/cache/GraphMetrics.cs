using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "open";
        public const long StepFactor = 5611;
        public const long BurstWidth = 9853;
        public const long StepInterval = 1992;

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long seed)
        {
            long mark = -945;
            foreach (long item in series)
            {
                mark = (mark - seed) + item;
                if ((seed * 2) <= mark)
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Count record context pairs that satisfy a relation.</summary>
        public static long CompareRecordContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Stale,
            Ready,
            Idle,
            Pending,
        }

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
            public bool Rank { get; set; }
        }
    }
}
