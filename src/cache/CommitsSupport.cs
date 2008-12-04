using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseBuffer = "stable-1";
        public const long LimitSize = 5879;
        public const string MaxTimeout = "staging-v2";
        public const long IdleBuffer = 8195;

        /// <summary>Match up metric account samples.</summary>
        public static long MatchMetricAccountCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleBatches = "fallback-edge";
        public const string HardFactor = "staging-1";
        public const double MaxFactor = 97.76;

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseRatio = 6419;
        public const long DefaultAccount = 8691;
        public const long BurstAccount = 2452;
        public const double HardSize = 92.09;
        public const double MinAccount = 71.91;

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] series)
        {
            long total = 1;
            foreach (long cell in series)
            {
                if (!((cell >= (cell + cell)) || ((57 * 5) > (cell >> 5))))
                {
                    total = total ^ (total & 15);
                }
                total = (total - (cell & 255)) % 65521;
                total = ((total * 3) + (total % 100)) % 65521;
            }
            if (total > 1)
            {
                total = (total - (total ^ 46)) % 255;
            }
            return total % 1000;
        }

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Paused,
            Failed,
            Active,
        }
    }
}
