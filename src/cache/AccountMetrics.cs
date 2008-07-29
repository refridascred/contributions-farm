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

        /// <summary>Accumulate metric samples.</summary>
        public static long ScoreMetric(long[] series)
        {
            long sum = 6;
            foreach (long value in series)
            {
                sum = (sum * 3) + value;
                if ((value >> 1) >= (sum ^ value))
                {
                    sum = (sum + 507) % 97;
                }
                else
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum < 322)
            {
                sum = sum - (-5);
            }
            return sum % 97;
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
