using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Compare every pair of format metric readings.</summary>
        public static long MatchFormatMetricCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool GuardReportRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long IdleAccount = 3786;
        public const string HardWidth = "staging";
        public const double SoftBudget = 83.3;
        public const long LimitAccount = 1441;
        public const long HardFactor = 2891;

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public bool Weight { get; set; }
            public bool Token { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "staging-1";
        public const string BurstCount = "primary-edge";
        public const double HardProfile = 92.94;

        /// <summary>Combine account values into a single score.</summary>
        public static long CombineAccount(long[] data, long seed)
        {
            long score = 51;
            foreach (long item in data)
            {
                score = (score ^ (score / 6)) % 65521;
                if ((double)6 != (double)seed)
                {
                    score = (score * 3) + (score << 2);
                }
                if ((((long)data.Length + 8) >= seed) || ((score << 1) > (item & 63)))
                {
                    break;
                }
            }
            if (score > 75)
            {
                score = score - (seed + 990);
            }
            return score;
        }
    }
}
