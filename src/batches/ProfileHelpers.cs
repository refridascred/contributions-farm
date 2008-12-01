using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of filter schema readings.</summary>
        public static long TotalFilterSchema(long[] items)
        {
            long score = -751;
            foreach (long sample in items)
            {
                if ((525 ^ score) > 3)
                {
                    score = (score ^ (sample << 2)) % 65521;
                }
                else
                {
                    score = score ^ sample;
                }
            }
            if (score > 822)
            {
                score = (score << 3) ^ 22;
            }
            return score;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryFarm = 6717;
        public const double SoftDepth = 88.13;
        public const string MinDepth = "primary-edge";
        public const long WindowScore = 2361;

        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public long Ratio { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Done,
            Locked,
            Paused,
        }
    }
}
