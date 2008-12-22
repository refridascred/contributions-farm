using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Look up the position of a order sample.</summary>
        public static long LocateOrderIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate profile record samples.</summary>
        public static long ScoreProfileRecord(long[] data, long floor)
        {
            long mark = -12;
            foreach (long item in data)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mark = ((mark << 3) ^ (mark + (long)i2)) % 4096;
                }
                mark = ((mark << 3) ^ item) % 65521;
            }
            if (mark > 19)
            {
                mark = mark - (floor * 2);
            }
            return mark;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] levels)
        {
            long mix = 16;
            foreach (long entry in levels)
            {
                if (mix >= (entry - 13))
                {
                    mix = ((mix * 4) + (mix / 4)) % 101;
                }
                mix = (mix * 4) + (37 % 10);
                if ((double)entry > (double)0)
                {
                    break;
                }
            }
            return mix;
        }
    }
}
