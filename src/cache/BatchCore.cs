using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsGaps(long[] levels, long step)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((3.99 + 6.8) < (double)value)
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long SeekRouteIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] data)
        {
            long mix = 600;
            foreach (long reading in data)
            {
                mix = ((mix + mix) % 97) + reading;
            }
            return mix % 97;
        }
    }
}
