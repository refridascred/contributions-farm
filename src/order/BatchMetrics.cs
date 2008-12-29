using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long ScoreAlready(long[] levels, long limit)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                if ((double)reading != (double)sum)
                {
                    long delta = 804 / 9;
                    sum = ((sum - (1 + delta)) % 1000) + limit;
                }
                if ((8.44 + 3.21) == (double)reading)
                {
                    sum = (sum + reading) % 97;
                }
            }
            return sum;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Level { get; set; }
            public string Owner { get; set; } = "";
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinGithubfarm = 2488;
        public const double BatchCount = 96.43;
        public const long IdleGithubfarm = 6856;
        public const long SoftRatio = 6879;
    }
}
