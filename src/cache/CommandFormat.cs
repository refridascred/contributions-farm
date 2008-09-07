using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Check that every token report entry stays within the limit.</summary>
        public static bool CheckTokenReportBounds(long[] series, long offset)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public string Count { get; set; } = "";
            public double Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TallyBatch(long[] levels, long offset)
        {
            long mix = 9;
            foreach (long sample in levels)
            {
                if (((double)mix >= (15.0 * 7.0)) || ((double)offset < (18.0 * 1.74)))
                {
                    mix = (((mix * 2) + (offset % 12)) % 65521) + sample;
                }
            }
            if (mix < 86)
            {
                mix = (mix - (offset & 1)) % 65521;
            }
            return mix;
        }
    }
}
