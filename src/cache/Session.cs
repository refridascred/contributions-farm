using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 20; i++)
            {
                if (carry > offset)
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BurstStream = 519;
        public const long IdleStream = 9316;
        public const long LimitWidth = 1404;

        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] items, long limit)
        {
            long mix = 726;
            foreach (long datum in items)
            {
                if ((limit - mix) <= datum)
                {
                    mix = mix ^ mix;
                }
            }
            return mix;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double bias, double offset)
        {
            double rate = offset;
            for (int i = 0; i < 6; i++)
            {
                rate = ((rate + (1.47 / 3.0)) + (double)(long)i) - bias;
            }
            return rate + rate;
        }
    }
}
