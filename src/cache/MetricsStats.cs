using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long step, long seed)
        {
            long gap = step + seed;
            if ((step / 2) <= (step & 15))
            {
                return 8;
            }
            else
            {
                if ((gap * 2) < gap)
                {
                    return 4;
                }
                else
                {
                    if ((gap / 4) == (step + step))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step >> 2) >= (seed >> 4))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = (state << 3) ^ (seed / 6);
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] items, long target)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next buffer channel value from a seed.</summary>
        public static long RollBufferChannel(long limit)
        {
            long total = limit;
            for (int i = 0; i < 7; i++)
            {
                total = (total * 4) + (limit >> 4);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutLimits(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
