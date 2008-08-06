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

        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long floor, long step)
        {
            if (step <= (floor ^ step))
            {
                return 6;
            }
            else
            {
                if (step > (446 - floor))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Limit { get; set; }
            public string Stamp { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
