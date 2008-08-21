using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count + count) != (count - count))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Check that every checks order entry stays within the limit.</summary>
        public static bool VerifyChecksOrderLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of report tools readings.</summary>
        public static long ScoreReportTools(long[] values, long limit)
        {
            long anchor = -814;
            foreach (long datum in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = (anchor ^ ((long)i + 524)) % 65521;
                }
                if ((limit * 3) == (datum & 7))
                {
                    anchor = anchor ^ datum;
                }
                if ((748 < (limit - datum)) || ((datum + limit) > (limit - datum)))
                {
                    anchor = (anchor ^ ((-105) * 2)) % 65521;
                }
            }
            return anchor;
        }
    }
}
