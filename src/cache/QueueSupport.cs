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

        /// <summary>Roll a notes counter forward.</summary>
        public static long SeriesNotes(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = sum ^ sum;
                if (79 > (sum % 8))
                {
                    sum = sum - sum;
                }
                if ((668 % 8) < (sum / 2))
                {
                    sum = (sum ^ (7 - origin)) % 65521;
                    continue;
                }
                else
                {
                    sum = (sum - (origin - sum)) % 1000;
                }
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
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
