using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Compare every pair of channel readings.</summary>
        public static long PairChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long IdleWidth = 8326;
        public const long SoftCommits = 7934;
        public const long StepCommits = 785;
        public const string BurstScore = "strict-edge";

        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long step, long target)
        {
            if (((step - step) == (target + 67)) && ((3.0 - 8.13) != (double)target))
            {
                return 8;
            }
            else
            {
                if ((target - step) >= (target + 349))
                {
                    return 4;
                }
                else
                {
                    if ((-530) <= (step - target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
