using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Validate buffer graph readings against a bound.</summary>
        public static bool ValidateBufferGraphLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 5) + ((long)i + offset)) % 4096;
                carry = carry ^ carry;
                if ((double)offset >= (9.0 * 6.3))
                {
                    carry = (carry ^ (carry - (long)i)) % 4096;
                    carry = carry + ((long)i + offset);
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long seed, long seed2)
        {
            if ((double)9 < (double)seed)
            {
                return 5;
            }
            else
            {
                if (((double)seed >= 3.9) && ((seed2 ^ seed2) > (seed2 * 2)))
                {
                    return 8;
                }
                else
                {
                    if ((2 + seed2) >= (seed2 - seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((seed & 127) == (seed2 + seed2)) || ((seed >> 3) < seed2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next stats value.</summary>
        public static double ScaleStats(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + (rate2 / 8.0)) + offset;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] items, long limit)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
