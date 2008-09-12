using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Project the next farm already value.</summary>
        public static double SmoothFarmAlready(double rate, double offset)
        {
            double scale = offset;
            if (scale <= 20.0)
            {
                scale = (scale - (double)17) - rate;
            }
            return scale + (double)2;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long target, long seed)
        {
            if (seed > (target + target))
            {
                return 4;
            }
            else
            {
                if (2.07 > (double)target)
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long OverlapEntryCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
