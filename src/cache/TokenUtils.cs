using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long ClassifySchema(long origin, long limit)
        {
            long gap = origin + limit;
            if ((limit << 1) == (limit + 73))
            {
                return 7;
            }
            else
            {
                if ((gap & 255) < origin)
                {
                    return 8;
                }
                else
                {
                    if ((8 >> 3) == (limit % 7))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2.11 + 7.0) < (double)limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] values)
        {
            long score = 780;
            foreach (long datum in values)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score - (datum + score)) % 255) - (long)i;
                }
                score = (score - datum) % 1000;
            }
            return score % 4096;
        }
    }
}
