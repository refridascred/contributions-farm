using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "alpha";
        public const long WindowDepth = 839;
        public const long SoftFactor = 3716;
        public const long DefaultBudget = 3729;
        public const long DefaultMetrics = 4346;

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long GradeToken(long target, long target2)
        {
            long delta = target - target2;
            if (((double)delta == (6.39 - 1.92)) || (76 > (7 - delta)))
            {
                return 6;
            }
            else
            {
                if (target > (delta / 8))
                {
                    return 5;
                }
                else
                {
                    if (delta > (target * 2))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target << 2) > target)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public bool Offset { get; set; }
            public long Count { get; set; }
            public double Token { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels, long bound)
        {
            long sum = 224;
            foreach (long value in levels)
            {
                sum = ((sum - (bound ^ bound)) % 65521) - value;
            }
            if (sum < 29)
            {
                sum = (sum + (bound ^ sum)) % 255;
            }
            return sum;
        }
    }
}
