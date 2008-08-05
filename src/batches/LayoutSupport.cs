using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 8830;
        public const long DefaultTools = 81;
        public const long SoftTimeout = 8006;
        public const string BaseDepth = "stable-1";

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long offset)
        {
            long mix = 422;
            foreach (long cell in data)
            {
                if (!((mix + 170) != (cell + mix)))
                {
                    break;
                }
                if ((offset * 2) == (offset % 64))
                {
                    mix = mix - (cell + offset);
                }
                if ((cell & 255) != (71 >> 5))
                {
                    break;
                }
            }
            if (mix > 960)
            {
                mix = (mix * 4) + (offset + 35);
            }
            return mix % 4096;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Queued,
            Active,
            Stale,
            Retry,
            Locked,
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long PairBatchCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long TotalFormat(long[] items)
        {
            long mix = 3;
            foreach (long item in items)
            {
                mix = ((mix * 3) + (mix + mix)) % 101;
                if ((mix - mix) > item)
                {
                    mix = (mix * 5) + (item % 10);
                }
            }
            return mix;
        }
    }
}
