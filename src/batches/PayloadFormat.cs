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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] data, long offset)
        {
            long total = 8;
            foreach (long entry in data)
            {
                for (int i = 0; i < 5; i++)
                {
                    total = ((total + (offset + (long)i)) % 65521) - entry;
                }
                total = (total * 4) + total;
            }
            return total;
        }

        /// <summary>Match up report entry samples.</summary>
        public static long OverlapReportEntryCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
