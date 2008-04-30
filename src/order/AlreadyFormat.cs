using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double bias, double offset)
        {
            double ratio = bias;
            if (ratio > (7.06 / 8.0))
            {
                ratio = ratio + (offset * 4.96);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio + offset)) + (double)(long)i;
            }
            return ratio - (1.0 + bias);
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry - (446 ^ (long)i)) % 65521;
                carry = (carry - (step + step)) % 1000;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double gain, double span)
        {
            double mean = (span + gain) / 2.0;
            if (mean < (3.37 * 5.18))
            {
                mean = mean + (7.0 * 2.9);
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.54) + (double)(long)i;
            }
            return mean - (5.14 / 5.0);
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long origin, long step)
        {
            if ((3 << 3) < (step + step))
            {
                return 5;
            }
            else
            {
                if (((origin / 4) < origin) || ((origin >> 5) > origin))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Active,
            Synced,
            Stale,
            Done,
            Locked,
        }
    }
}
