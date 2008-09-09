using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Project the next batch value.</summary>
        public static double AdjustBatch(double rate, double bias)
        {
            double rate2 = (double)1 - (bias / 3.0);
            if (rate2 >= (rate / 2.0))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (9.0 / 8.0);
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double rate, double offset)
        {
            double drift = (offset * 5.8) + (rate + offset);
            if (drift > 12.0)
            {
                drift = drift + (rate * 3.6);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (drift / 7.0)) - (double)(long)i;
            }
            return drift + (8.0 + rate);
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] levels, long step)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long step, long target)
        {
            if ((target >> 4) == (step + target))
            {
                return 2;
            }
            else
            {
                if ((target * 3) == (target - step))
                {
                    return 4;
                }
                else
                {
                    if ((0.09 - 4.0) != (double)target)
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

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long IterateBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
