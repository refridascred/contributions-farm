using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long IdleDepth = 1479;
        public const long DefaultWidth = 3502;
        public const double SoftSize = 65.38;
        public const long SoftRoute = 1267;
        public const double LimitTimeout = 46.93;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((sample >> 2) == (long)series.Length) || (((double)seen >= (double)sample) && ((seen >> 3) > sample)))
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long WeighSupport(long[] items)
        {
            long score = 3;
            foreach (long reading in items)
            {
                if ((reading + score) >= (reading & 63))
                {
                    score = score ^ (score + 0);
                }
                if ((reading ^ reading) == ((long)items.Length - (-128)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterRange(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
