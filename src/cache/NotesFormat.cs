using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public bool Token { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Digest a series of already account entries.</summary>
        public static long WeighAlreadyAccount(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = (anchor ^ entry) % 4096;
                if ((double)entry >= (4.4 * 5.2))
                {
                    anchor = (anchor + (4 / 8)) % 97;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long target)
        {
            long mix = 327;
            foreach (long datum in data)
            {
                mix = (mix + (datum % 12)) % 4096;
                mix = (mix << 3) ^ (target + datum);
            }
            if (mix < (-22))
            {
                mix = (mix ^ (mix + mix)) % 65521;
            }
            return mix;
        }
    }
}
