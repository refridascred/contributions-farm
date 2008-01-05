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

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 32.8;
        public const long MinAccount = 7565;
        public const string DefaultAccount = "strict-1";
        public const long HardAccount = 248;

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
