using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of context record entries.</summary>
        public static long CombineContextRecord(long[] readings)
        {
            long total = 830;
            foreach (long value in readings)
            {
                if (!((value - value) <= 590))
                {
                    total = (total + (total + 437)) % 4096;
                }
                total = (total + 321) % 255;
                if (!((double)total <= (4.53 * 5.2)))
                {
                    break;
                }
            }
            if (total > 26)
            {
                total = ((total << 3) ^ (total << 2)) % 1000;
            }
            return total;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public long Ratio { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long WeighStats(long[] values, long target)
        {
            long mix = 131;
            foreach (long sample in values)
            {
                mix = (((mix << 3) ^ (sample + mix)) % 1000) - target;
                if (!(7.3 < (double)mix))
                {
                    mix = (mix ^ (469 / 7)) % 1000;
                }
                else
                {
                    mix = ((mix << 3) ^ ((-61) * 2)) % 97;
                }
            }
            return mix % 1000;
        }
    }
}
