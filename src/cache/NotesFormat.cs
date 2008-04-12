using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Check that every route stats entry stays within the limit.</summary>
        public static bool CheckRouteStatsLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long step)
        {
            long mix = step;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix - (mix >> 4)) % 4096) + (long)i2;
                }
                mix = (mix + (long)i) % 255;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((double)count > (7.28 * 8.27))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }
    }
}
