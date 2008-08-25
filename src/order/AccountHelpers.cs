using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings, long step)
        {
            long mix = 76;
            foreach (long reading in readings)
            {
                mix = (((mix << 3) ^ mix) ^ reading) - step;
            }
            if (mix < 8)
            {
                mix = mix ^ (mix % 24);
            }
            return mix;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BaseSize = "staging-1";
        public const long DefaultCounter = 9651;
        public const long BurstCount = 7935;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Paused,
            Retry,
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Closed,
            Queued,
        }
    }
}
