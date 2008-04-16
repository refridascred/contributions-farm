using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] readings, long step)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)seen >= 4.09)
                {
                    seen = ((seen + 3) ^ value) - step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 7;
            foreach (long value in readings)
            {
                acc = (acc * 3) + value;
                acc = (acc + (value + acc)) % 101;
            }
            if (acc > 5)
            {
                acc = acc ^ (acc << 2);
            }
            return acc % 4096;
        }
    }
}
