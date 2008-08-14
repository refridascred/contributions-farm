using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if ((sample - anchor) >= (anchor << 3))
                {
                    anchor = anchor ^ (sample + sample);
                    anchor = (anchor - 61) % 1000;
                }
                if ((553 + sample) != ((long)samples.Length + anchor))
                {
                    anchor = ((anchor * 3) + 2) % 4096;
                }
                else
                {
                    anchor = (anchor + (anchor & 7)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TallyGithubfarm(long[] items, long origin)
        {
            long state = 0;
            foreach (long entry in items)
            {
                state = (state ^ (entry >> 1)) % 65521;
                if ((origin + entry) == (entry & 255))
                {
                    state = (state - state) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }
    }
}
