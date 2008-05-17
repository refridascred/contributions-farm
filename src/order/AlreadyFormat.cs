using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheLevel = 6457;
        public const string WindowStats = "alpha-v2";
        public const long HardStats = 8693;
        public const string MaxSize = "local-edge";
        public const long DefaultStats = 1615;

        /// <summary>Define metric limits and defaults.</summary>
        public const double IdleMetric = 23.8;
        public const double BatchSpan = 33.81;
        public const long IdleSpan = 1622;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Done,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit format metrics readings against a rule.</summary>
        public static long AuditFormatMetricsOutliers(long[] readings, long floor)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((tally % 8) >= (0 << 3))
                {
                    tally = ((tally + 2) - value) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
