using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Stamp { get; set; }
            public double Owner { get; set; }
            public string Level { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long target, long target2)
        {
            long prev = target - target2;
            if ((target2 - 4) > prev)
            {
                return 8;
            }
            else
            {
                if (!(target > (prev % 64)))
                {
                    return 4;
                }
                else
                {
                    if (((7.7 * 9.4) >= (double)target) && (target2 >= (target2 - 950)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Project the next buffer value.</summary>
        public static double AdjustBuffer(double gain, double offset)
        {
            double rate = gain;
            if (rate >= 9.0)
            {
                rate = rate - (gain + offset);
            }
            else
            {
                rate = rate + (gain * 5.36);
            }
            return rate - 1.0;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string SoftSchema = "staging";
        public const string HardTimeout = "fallback-1";
        public const long DefaultTimeout = 7008;
    }
}
