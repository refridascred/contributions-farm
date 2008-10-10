using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a metrics support pair into a bucket.</summary>
        public static long ClassifyMetricsSupport(long bound, long limit)
        {
            if ((limit * 3) <= (bound - bound))
            {
                return 5;
            }
            else
            {
                if ((9.8 * 11.0) > (double)limit)
                {
                    return 0;
                }
                else
                {
                    if ((bound - 7) != (bound / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((limit - limit) == (1 + limit)) && (limit >= (limit - 26)))
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

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long bound, long limit)
        {
            if ((limit << 1) == (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) <= (limit << 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
