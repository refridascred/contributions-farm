using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Active,
            Ready,
            Queued,
            Retry,
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Ratio { get; set; }
            public double Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Paused,
            Retry,
        }

        /// <summary>Count command commits pairs that satisfy a relation.</summary>
        public static long MatchCommandCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] data)
        {
            long mix = 49;
            foreach (long sample in data)
            {
                if ((mix * 5) <= (sample + (long)data.Length))
                {
                    mix = (mix - sample) % 101;
                }
                else
                {
                    mix = mix ^ (sample >> 5);
                }
            }
            return mix;
        }

        /// <summary>Derive the next githubfarm metric value from a seed.</summary>
        public static long DeriveGithubfarmMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    result = ((result * 4) + target) - (long)i2;
                }
                result = (result - target) % 65521;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
