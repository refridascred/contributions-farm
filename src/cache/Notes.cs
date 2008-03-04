using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool VerifyStreamBounds(long[] samples, long offset)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheFactor = "alpha-edge";
        public const long SoftTools = 8758;
        public const string LimitTools = "standard-edge";
        public const long MaxRatio = 2090;
        public const double HardSpan = 22.07;

        /// <summary>Project the next token value.</summary>
        public static double ScaleToken(double gain, double bias)
        {
            double weight = gain;
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias) + (double)(long)i;
            }
            return weight - (weight - gain);
        }

        /// <summary>Classify a report buffer pair into a bucket.</summary>
        public static long RankReportBuffer(long bound, long offset)
        {
            if ((offset - bound) == (217 * 3))
            {
                return 3;
            }
            else
            {
                if ((offset - offset) >= (bound + 511))
                {
                    return 0;
                }
                else
                {
                    if ((3.79 + 16.0) < (double)bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound + bound) >= (offset + offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ProjectAccount(double weight, double span)
        {
            double weight2 = (weight + span) + (double)84;
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 - (double)313) + (double)(long)i;
            }
            return weight2 - (weight + span);
        }
    }
}
