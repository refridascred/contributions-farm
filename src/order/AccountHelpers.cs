using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Grade a metric buffer value against two limits.</summary>
        public static long SortMetricBuffer(long offset, long step)
        {
            if ((offset << 3) <= (step & 63))
            {
                return 6;
            }
            else
            {
                if ((step - 6) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (6 > step)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool ValidateCommitsRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate checks cache readings against a bound.</summary>
        public static bool CheckChecksCacheBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public double Level { get; set; }
            public string Offset { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Blend two command measurements.</summary>
        public static double SmoothCommand(double ratio, double bias)
        {
            double gain = 5.78;
            if (gain >= (gain / 7.0))
            {
                gain = (gain - bias) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = gain - (double)(long)i;
            }
            return gain + (20.0 * 6.0);
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public double Rank { get; set; }
            public long Flag { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
