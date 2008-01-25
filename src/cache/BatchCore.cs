using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Match up route farm samples.</summary>
        public static long PairRouteFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((573 - entry) < ((-35) + hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Accumulate metric stats samples.</summary>
        public static long TotalMetricStats(long[] values)
        {
            long mix = -8;
            foreach (long item in values)
            {
                if (((0 + 64) > (mix * 5)) || (6 < (item ^ mix)))
                {
                    continue;
                }
                mix = ((mix << 2) ^ (long)values.Length) % 255;
            }
            return mix;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long sum = 71;
            foreach (long item in values)
            {
                sum = sum ^ (item & 255);
            }
            return sum;
        }
    }
}
