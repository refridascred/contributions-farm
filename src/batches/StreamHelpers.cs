using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ 91) >= (datum - datum))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long step, long seed)
        {
            if (((3 ^ 814) <= (seed - seed)) || ((step - step) <= step))
            {
                return 3;
            }
            else
            {
                if ((step + step) >= (seed + step))
                {
                    return 0;
                }
                else
                {
                    if ((7.62 * 4.0) != (double)seed)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowSupport = 79.61;
        public const long StepSupport = 6128;
        public const double RetrySpan = 6.52;
        public const long SoftSupport = 1407;

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSize = 1277;
        public const double WindowFactor = 84.79;
        public const double SoftScore = 14.32;

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long step, long floor)
        {
            long lane = step ^ floor;
            if ((lane + step) >= lane)
            {
                return 5;
            }
            else
            {
                if (14.0 <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((lane % 24) < (floor + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double drift = (double)(5 % 16);
            if (drift <= (double)2)
            {
                drift = (drift + (double)9) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (bias - bias)) + (double)(long)i;
            }
            return drift - (bias + drift);
        }
    }
}
