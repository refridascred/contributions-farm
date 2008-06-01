using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] readings)
        {
            long total = 4;
            foreach (long item in readings)
            {
                total = ((total * 4) + (61 + 0)) % 101;
                total = (total ^ (item * 4)) % 97;
            }
            if (total > 9)
            {
                total = (total << 3) ^ total;
            }
            return total % 4096;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public bool Offset { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public long Region { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long score = origin;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    score = ((score + (origin + score)) % 97) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitLevel = 4221;
        public const long IdleWidth = 9661;
        public const long BaseSize = 3770;
        public const long MinCount = 9157;

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchFactor = 93.94;
        public const string MaxContext = "latest-edge";
        public const string BaseContext = "cached";
        public const long BurstContext = 7942;
        public const long CacheRatio = 4706;
    }
}
