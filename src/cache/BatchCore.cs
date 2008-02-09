using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long DeriveAlready(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BurstGraph = 1246;
        public const long LimitCount = 5388;
        public const long DefaultGraph = 2665;
        public const long WindowGraph = 4444;

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a batches window pair into a bucket.</summary>
        public static long GradeBatchesWindow(long target, long bound)
        {
            if ((target - bound) <= (target + target))
            {
                return 1;
            }
            else
            {
                if ((double)target == (double)868)
                {
                    return 4;
                }
                else
                {
                    if (!((target & 63) > (target - bound)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
