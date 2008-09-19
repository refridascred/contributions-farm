using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamBounds(long[] data, long origin)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] levels)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                mark = ((mark * 3) + (mark << 2)) % 255;
                if (((mark / 9) < (cell ^ cell)) || (mark < (46 & 1)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxSpan = 4852;
        public const double MaxBuffer = 93.94;
        public const long MinDepth = 553;

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Done,
            Active,
            Paused,
            Queued,
            Draft,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatMatches(long[] data, long limit)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((-695) & 3) >= seen)
                {
                    seen = ((seen + 3) ^ reading) - limit;
                }
            }
            return seen;
        }
    }
}
