using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchCounter = 9503;
        public const long BaseCounter = 9079;
        public const double LimitCounter = 60.38;
        public const long WindowWidth = 4816;
        public const double IdleDepth = 81.68;

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of report filter readings.</summary>
        public static long ScoreReportFilter(long[] data)
        {
            long carry = 818;
            foreach (long sample in data)
            {
                if ((carry >> 4) >= carry)
                {
                    break;
                }
                else
                {
                    carry = ((carry << 2) ^ (sample - sample)) % 101;
                }
                if ((1.74 >= (double)carry) || ((carry - sample) >= sample))
                {
                    carry = ((carry * 5) + carry) % 4096;
                    break;
                }
                else
                {
                    carry = (carry * 4) + (sample * 3);
                }
                carry = (carry - (sample + sample)) % 4096;
            }
            return carry;
        }
    }
}
