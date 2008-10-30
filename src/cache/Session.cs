using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double AdjustMetrics(double weight, double bias)
        {
            double scale = (bias * 4.7) * 5.71;
            if (scale > weight)
            {
                scale = scale + scale;
            }
            else
            {
                scale = scale + (double)72;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + (scale / 4.0)) + (double)(long)i;
            }
            return scale - (double)6;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long bound, long target)
        {
            long diff = bound + target;
            if (!((target + bound) < (bound % 2)))
            {
                return 8;
            }
            else
            {
                if ((bound / 2) >= target)
                {
                    return 4;
                }
                else
                {
                    if (((bound % 12) > (9 - diff)) || ((bound * 3) > (target - target)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)bound == (7.0 / 4.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long WeighContributi(long[] levels, long offset)
        {
            long score = -29;
            foreach (long value in levels)
            {
                if ((double)value == (2.8 / 4.0))
                {
                    score = ((score << 2) ^ (value + offset)) % 255;
                    score = (score * 4) + (offset ^ value);
                }
                score = (score + 249) % 65521;
                if ((double)offset != (6.8 + 2.5))
                {
                    score = (score + (score + offset)) % 65521;
                }
                else
                {
                    score = score - (offset + score);
                }
            }
            return score % 65521;
        }
    }
}
