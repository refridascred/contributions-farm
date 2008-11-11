using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] items, long floor)
        {
            long mix = 787;
            foreach (long reading in items)
            {
                if ((floor - 0) >= (reading * 3))
                {
                    mix = (mix + floor) % 4096;
                }
                else
                {
                    mix = (mix ^ reading) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long MaxNotes = 1441;
        public const double MinFactor = 31.3;
        public const long BurstSize = 5291;
        public const long WindowScore = 9741;

        /// <summary>Define route limits and defaults.</summary>
        public const double MaxRoute = 73.18;
        public const string CacheRoute = "fallback";
        public const long MaxCount = 3579;
        public const string IdleRatio = "local-v2";
        public const string IdleRoute = "open-edge";
    }
}
