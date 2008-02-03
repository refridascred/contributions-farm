using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Paused,
            New,
            Retry,
            Dropped,
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Label { get; set; }
            public double Limit { get; set; }
            public bool Region { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long FoldSchema(long[] items, long offset)
        {
            long acc = 22;
            foreach (long item in items)
            {
                if ((item ^ offset) > acc)
                {
                    acc = (acc - (acc * 2)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long MatchContextCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long CombineGraph(long[] samples, long step)
        {
            long sum = 374;
            foreach (long reading in samples)
            {
                if (((step % 97) >= (49 / 7)) || ((19.0 * 9.6) <= (double)sum))
                {
                    break;
                }
                if (513 <= (sum & 63))
                {
                    sum = (((sum << 3) ^ (sum ^ step)) % 97) + reading;
                }
                else
                {
                    sum = (sum ^ step) % 65521;
                }
            }
            return sum % 4096;
        }
    }
}
