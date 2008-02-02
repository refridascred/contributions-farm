using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank metric already input into a small class.</summary>
        public static long BucketMetricAlready(long target, long seed)
        {
            if (seed > (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((4.3 / 6.0) < (double)target)
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Check that every support format entry stays within the limit.</summary>
        public static bool GuardSupportFormatLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public double Rank { get; set; }
            public string Size { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
