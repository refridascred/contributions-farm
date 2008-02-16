using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 1284;
        public const long MaxRatio = 350;
        public const long MaxSpan = 7758;
        public const long BatchCommits = 196;
        public const string BatchCount = "latest";

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstCounter = "staging-v2";
        public const long SoftLevel = 737;
        public const double StepSize = 38.64;

        /// <summary>Rank stats input into a small class.</summary>
        public static long SortStats(long floor, long step)
        {
            long span = floor + step;
            if (span >= (floor - step))
            {
                return 8;
            }
            else
            {
                if (floor < (step & 15))
                {
                    return 2;
                }
                else
                {
                    if ((floor - step) <= (span + floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((floor - span) >= ((-6) - span))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
