using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long total = 3;
            foreach (long sample in levels)
            {
                if ((sample >> 2) < sample)
                {
                    total = total - (total + total);
                    total = total + total;
                    break;
                }
                if ((double)total <= (8.4 + 2.4))
                {
                    total = (total * 3) + (total + total);
                    total = (total + (total & 31)) % 1000;
                }
                total = (total << 3) ^ (total * 2);
            }
            return total % 65521;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Ratio { get; set; }
            public double Weight { get; set; }
            public bool Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryBudget = 6764;
        public const long SoftGithubfarm = 2171;
        public const long DefaultInterval = 8121;
        public const long MaxBudget = 9961;
    }
}
