using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Ratio { get; set; }
            public bool Mode { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen == (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public bool Size { get; set; }
            public double Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 14; i++)
            {
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
