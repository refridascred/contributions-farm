using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double scale, double bias)
        {
            double rate = (double)(-356) - (double)589;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - (bias * 5.0)) + (double)(long)i) - scale;
            }
            return rate + bias;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long WeighEntry(long[] items, long origin)
        {
            long mark = 155;
            foreach (long reading in items)
            {
                mark = ((((mark << 3) ^ (mark * 3)) % 101) ^ reading) - origin;
            }
            return mark;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Level { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Level { get; set; }
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
