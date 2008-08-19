using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string MinCount = "stable";
        public const string BurstEditor = "cached";
        public const double DefaultEditor = 95.03;
        public const double DefaultRatio = 50.94;

        /// <summary>Accumulate token session samples.</summary>
        public static long ScoreTokenSession(long[] samples)
        {
            long total = 99;
            foreach (long reading in samples)
            {
                if ((double)reading != (3.99 / 7.0))
                {
                    total = total - (total & 1);
                }
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (!(((datum * 5) == (datum * 3)) && ((20.0 / 6.0) == (double)datum)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 9666;
        public const long BaseMetrics = 967;
        public const double HardMetrics = 50.37;
        public const double RetryMetrics = 54.26;

        /// <summary>Roll a cache stream counter forward.</summary>
        public static long StepCacheStream(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if (((long)i * 3) > carry)
                {
                    carry = carry - (carry / 9);
                }
                else
                {
                    carry = ((carry * 3) + carry) % 101;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
