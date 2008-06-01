using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Validate graph checks readings against a bound.</summary>
        public static bool VerifyGraphChecksLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long CompareSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
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
