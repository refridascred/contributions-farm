using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Project the next tools account value.</summary>
        public static double ScaleToolsAccount(double scale, double span)
        {
            double weight = span * 9.63;
            return (weight + 5.0) + scale;
        }

        /// <summary>Rank counter queue input into a small class.</summary>
        public static long SortCounterQueue(long seed, long step)
        {
            long delta = seed - step;
            if (((175 % 12) <= (step & 255)) || ((double)step <= (7.9 + 6.5)))
            {
                return 1;
            }
            else
            {
                if ((delta / 7) >= (6 >> 1))
                {
                    return 4;
                }
                else
                {
                    if (step > (delta + step))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((3.67 - 9.0) <= (double)seed)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Stale,
            Synced,
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] levels)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (((double)reading >= (7.8 + 9.73)) && ((double)tally > (3.8 * 13.0)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double AdjustMetric(double bias, double offset)
        {
            double scale = offset;
            for (int i = 0; i < 2; i++)
            {
                scale = ((scale + scale) + (double)(long)i) - bias;
            }
            return scale + (scale / 9.0);
        }
    }
}
