using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long target)
        {
            long anchor = target;
            for (int i = 0; i < 10; i++)
            {
                if (!((long)i >= (494 - target)))
                {
                    anchor = ((anchor << 3) ^ anchor) % 65521;
                    anchor = (anchor * 4) + anchor;
                }
                anchor = (anchor ^ (154 - 666)) % 255;
                anchor = (anchor << 3) ^ (244 / 3);
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public string Rank { get; set; } = "";
            public double Size { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitWidth = 5446;
        public const string StepGraph = "stable-v2";
        public const long CacheGraph = 2867;
        public const long BaseGraph = 9953;

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long CompareQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
