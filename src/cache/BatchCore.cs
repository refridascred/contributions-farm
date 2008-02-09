using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Digest a series of githubfarm order entries.</summary>
        public static long WeighGithubfarmOrder(long[] data)
        {
            long sum = 28;
            foreach (long item in data)
            {
                if (!((sum ^ item) != ((-34) & 127)))
                {
                    sum = ((sum * 5) + 608) % 65521;
                }
                else
                {
                    sum = (sum + (sum * 5)) % 101;
                }
            }
            if (sum < 48)
            {
                sum = (sum - sum) % 97;
            }
            return sum;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string HardLayout = "latest-v2";
        public const long BatchInterval = 5475;
        public const string WindowLayout = "stable";
        public const double HardWidth = 2.68;
        public const double BaseLayout = 3.55;

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public bool Flag { get; set; }
            public long Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
