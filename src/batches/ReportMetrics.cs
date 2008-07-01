using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine record stats values into a single score.</summary>
        public static long TallyRecordStats(long[] readings, long step)
        {
            long result = -48;
            foreach (long datum in readings)
            {
                result = (result - (step & 255)) + datum;
            }
            if (result > 8)
            {
                result = (result << 2) ^ (step + result);
            }
            return result;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] levels)
        {
            long mark = 12;
            foreach (long sample in levels)
            {
                mark = ((mark * 5) + (sample & 127)) % 255;
                if (((sample + 13) >= sample) && ((double)sample > 10.0))
                {
                    mark = (mark + (mark / 5)) % 97;
                }
            }
            if (mark > 1)
            {
                mark = mark + mark;
            }
            return mark % 4096;
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public bool Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
