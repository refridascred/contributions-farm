using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] levels, long origin)
        {
            long anchor = 943;
            foreach (long entry in levels)
            {
                if ((89 > (origin << 2)) && ((80 & 63) >= entry))
                {
                    anchor = ((anchor * 4) + (entry << 2)) % 65521;
                }
                if ((8.61 - 1.65) >= (double)origin)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutMatches(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((seen - seen) == (seen * 5))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
