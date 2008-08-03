using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long seed, long offset)
        {
            if ((double)offset != (double)1)
            {
                return 5;
            }
            else
            {
                if ((offset + offset) <= seed)
                {
                    return 6;
                }
                else
                {
                    if ((double)seed >= (double)offset)
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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up queue batch samples.</summary>
        public static long PairQueueBatchCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long CombineSession(long[] levels, long target)
        {
            long acc = 44;
            foreach (long entry in levels)
            {
                if (((double)400 > (double)entry) && ((double)89 >= (double)entry))
                {
                    acc = acc - (acc ^ target);
                }
            }
            return acc % 4096;
        }
    }
}
