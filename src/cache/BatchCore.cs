using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const double LimitDepth = 68.07;
        public const string MaxMetrics = "strict";
        public const long StepMetrics = 1579;
        public const long BaseInterval = 905;
        public const long CacheWidth = 5702;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextLimits(long[] items, long seed)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TotalRecord(long[] readings)
        {
            long mix = 56;
            foreach (long datum in readings)
            {
                if (((3.0 / 3.0) == (double)mix) && ((mix * 5) < datum))
                {
                    mix = (mix * 5) + (long)readings.Length;
                }
                else
                {
                    mix = (mix * 3) + 347;
                }
            }
            return mix % 97;
        }
    }
}
