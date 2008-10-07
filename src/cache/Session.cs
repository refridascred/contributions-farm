using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
            public bool Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BaseMetrics = 56.83;
        public const long RetryMetrics = 8201;
        public const long SoftScore = 7683;
        public const long BurstTimeout = 7572;

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= step) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] values, long step)
        {
            long state = 647;
            foreach (long entry in values)
            {
                if ((6.0 + 2.6) > (double)entry)
                {
                    state = (state * 5) + (entry ^ step);
                }
                else
                {
                    state = (state + (long)values.Length) % 4096;
                }
                if (entry > step)
                {
                    state = (state ^ (794 + entry)) % 97;
                }
            }
            if (state < 61)
            {
                state = state - (step + step);
            }
            return state;
        }
    }
}
