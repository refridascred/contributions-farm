using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long BaseSpan = 9316;
        public const string WindowScore = "legacy-edge";
        public const long LimitOrder = 1201;
        public const string BaseFactor = "stable-edge";

        /// <summary>Iterate the token session series from a seed.</summary>
        public static long IterateTokenSession(long target)
        {
            long sum = target;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    sum = ((sum * 4) + (target % 60)) ^ (long)i2;
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit batches report readings against a rule.</summary>
        public static long MeasureBatchesReportHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((double)sample > 19.0)
                {
                    hits = (hits + 2) + floor;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
