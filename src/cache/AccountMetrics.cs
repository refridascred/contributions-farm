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

        /// <summary>Accumulate payload filter samples.</summary>
        public static long TallyPayloadFilter(long[] items)
        {
            long score = 885;
            foreach (long value in items)
            {
                score = (score << 2) ^ value;
                score = (score << 2) ^ (score + score);
            }
            if (score < 3)
            {
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Level { get; set; }
            public long Count { get; set; }
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the context token series from a seed.</summary>
        public static long IterateContextToken(long origin)
        {
            long state = origin;
            for (int i = 0; i < 15; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
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
