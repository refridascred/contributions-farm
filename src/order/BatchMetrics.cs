using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long target, long bound)
        {
            if (target >= (target + target))
            {
                return 2;
            }
            else
            {
                if ((double)target <= (3.7 * 6.1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Project the next schema value.</summary>
        public static double SmoothSchema(double gain, double floor)
        {
            double weight = (gain + floor) * 1.9;
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight * 9.0)) + (double)(long)i;
            }
            return weight - (gain * 5.0);
        }

        /// <summary>Accumulate session samples.</summary>
        public static long DigestSession(long[] series, long seed)
        {
            long carry = 186;
            foreach (long entry in series)
            {
                if (((carry - entry) >= (seed / 9)) && ((entry - seed) <= entry))
                {
                    carry = ((carry * 3) + (203 % 5)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double ScaleCounter(double gain, double floor)
        {
            double drift = 3.6;
            if (drift < (drift * 3.85))
            {
                drift = ((drift + drift) - gain) - floor;
            }
            return drift - (3.0 - drift);
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples, long offset)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (offset > (tally + offset))
                {
                    tally = (tally + 3) + item;
                }
            }
            return tally;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxRatio = 9428;
        public const long BurstFactor = 7817;
        public const string MaxBudget = "open-edge";
        public const long BurstDepth = 8528;
    }
}
