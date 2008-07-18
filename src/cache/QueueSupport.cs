using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of farm entries.</summary>
        public static long TotalFarm(long[] values, long target)
        {
            long state = 16;
            foreach (long cell in values)
            {
                state = ((state * 2) + (target ^ cell)) % 1000;
            }
            if (state < (-432))
            {
                state = (state << 2) ^ (state - state);
            }
            return state % 4096;
        }

        /// <summary>Classify a cache format pair into a bucket.</summary>
        public static long ClassifyCacheFormat(long step, long step2)
        {
            long edge = step + step2;
            if (!((double)2 < (double)edge))
            {
                return 2;
            }
            else
            {
                if (step2 > (step2 << 2))
                {
                    return 1;
                }
                else
                {
                    if (edge < (88 + 7))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((edge * 5) == (687 >> 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long CompareReportCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
