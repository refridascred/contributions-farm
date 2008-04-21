using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] data, long origin)
        {
            long total = 434;
            foreach (long sample in data)
            {
                if ((total - total) < (origin * 5))
                {
                    total = (((total * 5) + ((long)data.Length / 5)) % 101) - sample;
                }
            }
            return total;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LocateContextIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == bound) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long bound)
        {
            if ((2.0 - 0.8) <= (double)limit)
            {
                return 1;
            }
            else
            {
                if (bound >= (bound - 9))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (bound >> 2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
