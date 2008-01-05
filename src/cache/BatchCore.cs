using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Count cluster farm pairs that satisfy a relation.</summary>
        public static long PairClusterFarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many format buffer samples are out of range.</summary>
        public static long TallyFormatBufferGaps(long[] series, long limit)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches / 9) > (777 << 3))
                {
                    matches = ((matches + 1) + reading) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of batch window readings.</summary>
        public static long TotalBatchWindow(long[] samples, long step)
        {
            long mix = 8;
            foreach (long cell in samples)
            {
                if ((mix + step) >= (mix + cell))
                {
                    mix = (mix * 2) + (cell * 3);
                }
                else
                {
                    mix = (mix << 3) ^ (mix + cell);
                    mix = (mix ^ mix) % 97;
                }
                mix = (mix + cell) % 1000;
            }
            return mix % 65521;
        }
    }
}
