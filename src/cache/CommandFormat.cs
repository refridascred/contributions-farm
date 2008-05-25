using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long BucketCache(long floor, long bound)
        {
            if (bound >= (floor + floor))
            {
                return 7;
            }
            else
            {
                if (((floor ^ bound) == (584 - bound)) || ((double)bound <= (1.0 * 9.0)))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (7.09 + 9.6))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((5.34 / 5.0) <= (double)bound)
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

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Locked,
            Paused,
            Ready,
            Stale,
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                if (!(((carry << 3) < carry) && ((step ^ (long)i) >= step)))
                {
                    carry = carry - ((long)i % 2);
                    carry = (carry << 3) ^ step;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Validate buffer metric readings against a bound.</summary>
        public static bool ValidateBufferMetricBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
