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

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long step)
        {
            long mark = step;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark + (51 % 5)) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
