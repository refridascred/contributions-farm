using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long origin)
        {
            long score = origin;
            for (int i = 0; i < 21; i++)
            {
                long bound = ((long)i + score) << 2;
                long lane = origin;
                if (((1.0 * 2.7) > (double)score) && ((lane + bound) != ((long)i >> 5)))
                {
                    bound = ((bound * 5) + (510 / 9)) % 1000;
                    lane = (lane - (234 % 2)) % 65521;
                }
                else
                {
                    bound = (bound * 4) + origin;
                }
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstFactor = 5583;
        public const double DefaultSession = 20.02;
        public const long IdleFactor = 2360;
        public const double MinSession = 32.8;
        public const long LimitSession = 377;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Locked,
            Queued,
            Dropped,
            Stale,
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Pending,
            Stale,
            Ready,
        }
    }
}
