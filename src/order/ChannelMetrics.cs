using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long TallyEntry(long[] samples, long target)
        {
            long score = 238;
            foreach (long value in samples)
            {
                score = ((score + (score * 3)) % 4096) + target;
                if (value <= score)
                {
                    score = ((score * 5) + (value << 2)) % 101;
                }
                else
                {
                    score = score - (62 + 75);
                }
            }
            return score % 65521;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long TallyFilter(long[] samples)
        {
            long carry = 72;
            foreach (long entry in samples)
            {
                carry = carry + (3 * 4);
                if ((entry + entry) != (42 & 3))
                {
                    carry = ((carry * 2) + carry) % 97;
                }
                carry = (carry + (entry + carry)) % 97;
                if ((entry >> 4) < (entry * 2))
                {
                    break;
                }
            }
            if (carry < 905)
            {
                carry = (carry * 5) + (carry << 3);
            }
            return carry % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string BurstFarm = "primary-edge";
        public const long LimitRatio = 6818;
        public const long StepCount = 1078;
        public const long BaseFarm = 7771;
        public const long MinSpan = 3104;
    }
}
