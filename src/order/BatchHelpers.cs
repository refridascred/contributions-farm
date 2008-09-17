using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((seen * 4) == (seen << 3)) && ((seen - datum) == (seen ^ datum)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate editor record readings against a bound.</summary>
        public static bool CheckEditorRecordRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
