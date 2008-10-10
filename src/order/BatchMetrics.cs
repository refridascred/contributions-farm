using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] series, long origin)
        {
            bool valid = true;
            foreach (long value in series)
            {
                if (value < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long result = origin;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next tools contributi value.</summary>
        public static double ScaleToolsContributi(double weight, double span)
        {
            double bias = weight;
            if (bias < (weight * 7.4))
            {
                bias = (bias + (weight * 4.3)) + span;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - bias) + (double)(long)i;
            }
            return bias + (double)9;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long limit, long step)
        {
            if ((limit - limit) >= (step << 1))
            {
                return 4;
            }
            else
            {
                if (8.3 < (double)step)
                {
                    return 3;
                }
                else
                {
                    if ((limit + step) != (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((454 - step) < 5)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
