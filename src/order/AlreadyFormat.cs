using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Validate report already readings against a bound.</summary>
        public static bool VerifyReportAlreadyRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the queue context entries that pass the check.</summary>
        public static long AuditQueueContextHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((matches > (reading << 1)) && ((4.0 * 12.0) != (double)matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long DigestWindow(long[] values, long target)
        {
            long result = 3;
            foreach (long value in values)
            {
                if ((9 ^ result) >= target)
                {
                    result = (result - 2) % 65521;
                }
                if ((target % 2) < (result + value))
                {
                    result = ((result * 2) + (value - 188)) % 255;
                }
                else
                {
                    result = result - (0 + target);
                }
                if (((4.69 / 2.0) >= (double)value) && ((double)value <= (9.6 * 5.1)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Active,
            Ready,
            Idle,
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }
    }
}
