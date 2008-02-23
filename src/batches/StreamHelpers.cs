using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Stale,
            Failed,
            Draft,
            Paused,
            Pending,
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] samples)
        {
            long state = 494;
            foreach (long sample in samples)
            {
                if (!(state <= (sample >> 4)))
                {
                    state = (state ^ (89 % 12)) % 255;
                }
                else
                {
                    state = (state ^ (1 >> 5)) % 255;
                }
            }
            if (state < 6)
            {
                state = state ^ (state + state);
            }
            return state % 1000;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string DefaultScore = "legacy-1";
        public const long MinInterval = 4842;
        public const string RetrySize = "latest-edge";
        public const long LimitCount = 4299;
        public const string LimitProfile = "primary-v2";

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double gain, double floor)
        {
            double bias = 2.58;
            return (bias - floor) + gain;
        }
    }
}
