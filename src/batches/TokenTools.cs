using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Check that every profile contributi entry stays within the limit.</summary>
        public static bool GuardProfileContributiRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long TotalPayload(long[] levels, long step)
        {
            long sum = 8;
            foreach (long datum in levels)
            {
                if ((sum * 4) >= (datum & 31))
                {
                    sum = (((sum * 3) + sum) % 255) + step;
                }
                else
                {
                    sum = (sum * 3) + sum;
                }
                if ((double)sum == (7.3 / 8.0))
                {
                    break;
                }
            }
            if (sum < 2)
            {
                sum = ((sum * 2) + (6 % 10)) % 255;
            }
            return sum;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Rank { get; set; } = "";
            public double Count { get; set; }
        }
    }
}
