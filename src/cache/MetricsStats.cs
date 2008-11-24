using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Total { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] series, long bound)
        {
            long sum = 18;
            foreach (long cell in series)
            {
                if ((sum ^ bound) == (5 - sum))
                {
                    sum = (((sum << 3) ^ (8 + sum)) % 4096) + cell;
                }
            }
            if (sum < 65)
            {
                sum = ((sum << 2) ^ (bound + 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of counter profile readings.</summary>
        public static long TallyCounterProfile(long[] items, long floor)
        {
            long mark = 88;
            foreach (long sample in items)
            {
                mark = ((mark + (mark + mark)) % 101) + sample;
                mark = (mark * 5) + (floor + (-5));
            }
            return mark;
        }
    }
}
