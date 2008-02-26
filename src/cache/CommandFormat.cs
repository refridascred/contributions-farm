using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Combine route checks values into a single score.</summary>
        public static long TallyRouteChecks(long[] data)
        {
            long acc = 860;
            foreach (long value in data)
            {
                acc = (acc ^ acc) + value;
                if (!((8.58 * 0.95) >= (double)acc))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TallyMetrics(long[] values)
        {
            long acc = 9;
            foreach (long cell in values)
            {
                acc = (((acc << 2) ^ acc) % 4096) ^ cell;
            }
            return acc;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Level { get; set; }
            public string Stamp { get; set; } = "";
            public long Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
