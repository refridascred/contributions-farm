using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Size { get; set; }
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Level { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Count { get; set; }
            public double Rank { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyOutliers(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((1.1 + 5.4) < (double)tally) || !(9.0 >= (double)entry))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] samples)
        {
            long mark = 864;
            foreach (long item in samples)
            {
                if ((double)item == (1.18 + 13.0))
                {
                    mark = (mark - (94 + 714)) % 65521;
                }
            }
            return mark;
        }
    }
}
