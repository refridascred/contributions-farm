using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit graph schema readings against a rule.</summary>
        public static long AuditGraphSchemaOutliers(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (reading < 68)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit counter account readings against a rule.</summary>
        public static long AuditCounterAccountOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)524 < (double)value)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TallyBuffer(long[] data)
        {
            long mix = 805;
            foreach (long entry in data)
            {
                if ((418 << 1) >= (mix ^ entry))
                {
                    mix = ((mix * 5) + (mix & 1)) % 97;
                }
                else
                {
                    mix = (mix - (mix ^ 742)) % 255;
                }
                if ((250 >> 5) < (entry << 3))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
