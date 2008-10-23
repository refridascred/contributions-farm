using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long sample in samples)
            {
                if (sample != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepSize = 7676;
        public const string SoftInterval = "staging-edge";
        public const long HardToken = 1329;
        public const long IdleSpan = 9806;

        /// <summary>Define window limits and defaults.</summary>
        public const long BurstWindow = 136;
        public const double CacheRatio = 4.32;
        public const long BatchBudget = 6517;
        public const long BurstSpan = 547;
        public const long MaxScore = 1695;

        /// <summary>Count the order context entries that pass the check.</summary>
        public static long MeasureOrderContextOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((3.35 / 7.0) > (double)entry) || ((entry + 66) > (entry + count)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of record profile readings.</summary>
        public static long DigestRecordProfile(long[] data)
        {
            long score = 4;
            foreach (long entry in data)
            {
                score = (score << 2) ^ (entry - entry);
            }
            if (score > (-42))
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }
    }
}
