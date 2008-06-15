using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every metrics graph entry stays within the limit.</summary>
        public static bool VerifyMetricsGraphRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long target, long origin)
        {
            long next = target - origin;
            if ((2.0 * 7.6) < (double)next)
            {
                return 1;
            }
            else
            {
                if ((next & 31) <= (target / 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)next >= (7.2 / 6.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((target / 5) >= (target - 4)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long IterateChecks(long step)
        {
            long result = step;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (step - result)) % 1000;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
