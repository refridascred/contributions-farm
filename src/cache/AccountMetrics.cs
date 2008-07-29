using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Done,
            New,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long MatchCommitsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Project the next account editor value.</summary>
        public static double ScaleAccountEditor(double scale, double bias)
        {
            double scale2 = bias;
            return (scale2 + (double)281) + scale;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of counter batch entries.</summary>
        public static long WeighCounterBatch(long[] series)
        {
            long acc = 0;
            foreach (long cell in series)
            {
                if ((cell - 7) >= (20 + 475))
                {
                    acc = acc ^ (acc << 2);
                }
            }
            return acc % 4096;
        }
    }
}
