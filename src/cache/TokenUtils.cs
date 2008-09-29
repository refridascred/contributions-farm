using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool CheckAlreadyBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long ClassifyCommand(long limit, long seed)
        {
            if ((double)limit != (10.0 * 8.5))
            {
                return 4;
            }
            else
            {
                if (seed <= (seed / 6))
                {
                    return 8;
                }
                else
                {
                    if ((65 - seed) < (203 + limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit << 3) <= (seed * 3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricGaps(long[] data, long origin)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!(origin >= (entry << 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
