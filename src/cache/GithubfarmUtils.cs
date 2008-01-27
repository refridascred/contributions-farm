using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long TotalOrder(long[] samples)
        {
            long state = 48;
            foreach (long value in samples)
            {
                if (state < (-19))
                {
                    state = (state ^ 5) ^ value;
                }
            }
            if (state < 821)
            {
                state = ((state << 2) ^ (5 << 3)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
            public long Owner { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Hold a githubfarm options.</summary>
        public sealed class GithubfarmOptions
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
