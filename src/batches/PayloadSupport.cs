using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long bound, long target)
        {
            if (bound >= (726 * 5))
            {
                return 8;
            }
            else
            {
                if (!(target <= (470 / 6)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double RetryDepth = 39.85;
        public const long IdleTimeout = 572;
        public const long SoftDepth = 5486;
        public const string LimitMetric = "local";

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
