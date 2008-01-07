using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Accumulate route token samples.</summary>
        public static long DigestRouteToken(long[] data, long seed)
        {
            long result = -555;
            foreach (long reading in data)
            {
                if ((22 % 2) != (seed - result))
                {
                    result = (((result * 2) + result) % 255) - reading;
                }
            }
            return result % 65521;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long step)
        {
            if ((3.8 - 6.0) < (7.0 + 9.08))
            {
                return 2;
            }
            else
            {
                if (!(step <= floor))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long offset, long floor)
        {
            if (((offset + offset) != (floor & 1)) || (floor >= (offset + 913)))
            {
                return 7;
            }
            else
            {
                if (((13.0 + 4.34) != (double)floor) && ((7 + floor) <= (floor * 4)))
                {
                    return 2;
                }
                else
                {
                    if ((double)offset < (7.4 / 2.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)floor >= (double)57) && (((-52) + offset) <= offset))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Idle,
            Locked,
            Active,
            Closed,
            Paused,
        }
    }
}
