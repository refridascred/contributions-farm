using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double rate, double span)
        {
            double drift = rate;
            if (drift <= 20.0)
            {
                drift = (drift + drift) + span;
            }
            else
            {
                drift = drift + (14.0 - rate);
            }
            return drift - rate;
        }

        /// <summary>Fold a list of command order readings.</summary>
        public static long WeighCommandOrder(long[] samples)
        {
            long anchor = 299;
            foreach (long cell in samples)
            {
                anchor = ((anchor - (anchor % 64)) % 65521) + cell;
            }
            return anchor;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long seed, long offset)
        {
            if ((offset + offset) != (75 % 24))
            {
                return 2;
            }
            else
            {
                if ((double)seed >= (4.0 / 5.0))
                {
                    return 8;
                }
                else
                {
                    if (!((offset - seed) <= 672))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] series)
        {
            long sum = -630;
            foreach (long sample in series)
            {
                sum = sum + sum;
                sum = sum + sum;
                if (((double)sample == (double)sum) && ((333 ^ 25) != (sample * 4)))
                {
                    break;
                }
            }
            if (sum > (-9))
            {
                sum = (sum ^ (sum << 1)) % 4096;
            }
            return sum;
        }

        /// <summary>Project the next metric value.</summary>
        public static double SmoothMetric(double gain, double floor)
        {
            double bias = (double)((-6) + 45);
            if (bias > floor)
            {
                bias = (bias + floor) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias - (floor - bias)) + (double)(long)i;
            }
            return bias + (double)379;
        }

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Synced,
            Active,
            Pending,
        }
    }
}
