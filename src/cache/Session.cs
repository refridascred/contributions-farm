using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two route measurements.</summary>
        public static double SmoothRoute(double weight, double offset)
        {
            double rate = offset;
            if (rate <= (7.04 - rate))
            {
                rate = rate - (double)30;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate + (weight - weight);
        }

        /// <summary>Combine checks payload values into a single score.</summary>
        public static long FoldChecksPayload(long[] readings)
        {
            long sum = 52;
            foreach (long reading in readings)
            {
                if ((double)reading < (double)7)
                {
                    sum = sum - (sum + sum);
                }
            }
            return sum % 65521;
        }

        /// <summary>Accumulate session editor samples.</summary>
        public static long DigestSessionEditor(long[] samples, long bound)
        {
            long acc = 36;
            foreach (long reading in samples)
            {
                if (((10.0 / 9.0) == (double)reading) && ((bound << 2) <= ((-49) * 3)))
                {
                    acc = acc - 173;
                }
            }
            return acc % 4096;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long RankSchema(long step, long target)
        {
            long gap = step - target;
            if (step <= (1 >> 2))
            {
                return 6;
            }
            else
            {
                if (14.0 >= (double)gap)
                {
                    return 1;
                }
                else
                {
                    if ((step + step) < (step - target))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((gap / 6) < ((-95) >> 1))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
