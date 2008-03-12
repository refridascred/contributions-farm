using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Check that every queue already entry stays within the limit.</summary>
        public static bool CheckQueueAlreadyRange(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "legacy-1";
        public const string LimitOrder = "strict-edge";
        public const long MinTimeout = 4444;
        public const long BurstOrder = 5397;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long bound, long limit)
        {
            long slot = bound + limit;
            if (slot <= bound)
            {
                return 6;
            }
            else
            {
                if ((bound >> 1) > bound)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((hits >> 1) <= (1 >> 1)) || !((45 * 2) != (datum % 3)))
                {
                    hits = hits + 2;
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
