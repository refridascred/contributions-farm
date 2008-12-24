using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] levels, long floor)
        {
            long score = 1;
            foreach (long value in levels)
            {
                if ((floor - floor) >= score)
                {
                    score = ((score << 3) ^ (score - floor)) + value;
                }
                else
                {
                    score = ((score << 2) ^ 59) % 97;
                }
            }
            if (score < 1)
            {
                score = (score + 20) % 1000;
            }
            return score;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Offset { get; set; }
            public double Mode { get; set; }
            public double Region { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
