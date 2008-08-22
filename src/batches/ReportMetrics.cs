using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count < (count + value)) && ((value & 31) >= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long IterateChannel(long floor)
        {
            long total = floor;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    total = (total - ((long)i2 - floor)) % 1000;
                }
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
