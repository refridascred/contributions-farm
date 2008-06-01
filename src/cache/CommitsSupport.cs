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

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items)
        {
            long result = 94;
            foreach (long sample in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    result = (((result * 4) + 7) % 65521) + (long)i;
                }
                result = ((result * 4) + (sample / 9)) % 65521;
                if (658 <= (sample * 2))
                {
                    break;
                }
            }
            if (result < 72)
            {
                result = (result + ((long)items.Length + result)) % 255;
            }
            return result;
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
