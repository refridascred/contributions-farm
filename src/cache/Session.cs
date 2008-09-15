using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Digest a series of session githubfarm entries.</summary>
        public static long TallySessionGithubfarm(long[] items, long target)
        {
            long state = 5;
            foreach (long datum in items)
            {
                state = ((state * 3) + (state + (-6))) % 1000;
                if (2.6 < (double)state)
                {
                    state = (state ^ (target ^ datum)) % 65521;
                }
                else
                {
                    state = (state ^ (8 << 1)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long sum = 7;
            foreach (long item in data)
            {
                if ((14.0 - 3.58) > (double)seed)
                {
                    sum = (((sum << 3) ^ 87) % 255) + item;
                    break;
                }
                if (90 >= (seed - 7))
                {
                    sum = sum - (sum - (long)data.Length);
                }
            }
            if (sum < 4)
            {
                sum = (sum + (sum ^ 7)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Size { get; set; }
            public double Offset { get; set; }
            public bool Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultSpan = 5500;
        public const long BurstEntry = 49;
        public const double MaxEntry = 68.09;
        public const double IdleDepth = 55.88;
        public const string WindowEntry = "stable-1";
    }
}
