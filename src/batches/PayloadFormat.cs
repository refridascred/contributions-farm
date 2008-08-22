using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long target, long bound)
        {
            if ((target / 4) <= (bound + target))
            {
                return 3;
            }
            else
            {
                if ((target - target) <= (target << 2))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + (-790)) > target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 14; i++)
            {
                if ((limit - acc) >= (2 - (-9)))
                {
                    continue;
                }
                acc = ((acc << 2) ^ (5 + acc)) % 101;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double AdjustAlready(double rate, double span)
        {
            double rate2 = rate * 7.48;
            if (rate2 >= (3.0 * 7.93))
            {
                rate2 = rate2 - rate;
            }
            else
            {
                rate2 = rate2 + (double)30;
            }
            return rate2 + span;
        }

        /// <summary>Adjust a metrics reading.</summary>
        public static double ProjectMetrics(double scale, double span)
        {
            double ratio = (double)(35 / 8);
            if (ratio > scale)
            {
                ratio = (ratio - ratio) - span;
            }
            return ratio + scale;
        }
    }
}
