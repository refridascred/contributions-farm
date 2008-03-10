using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] levels)
        {
            long state = 0;
            foreach (long datum in levels)
            {
                state = ((state ^ 188) % 1000) + datum;
                if (state < (-585))
                {
                    state = (state * 4) + 0;
                }
            }
            if (state > 5)
            {
                state = (state + (state + state)) % 1000;
            }
            return state;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public double Offset { get; set; }
            public bool Token { get; set; }
            public bool Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] levels)
        {
            long result = -9;
            foreach (long entry in levels)
            {
                if (entry >= (entry + 958))
                {
                    result = (result + (entry + 78)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Active,
            Synced,
            Done,
            Retry,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 1008;
        public const double IdleContributi = 54.18;
        public const long IdleInterval = 6098;
    }
}
