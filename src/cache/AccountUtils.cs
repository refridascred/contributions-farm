using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long entry in levels)
            {
                if (entry >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 1235;
        public const long MinBatch = 3107;
        public const long MaxDepth = 9465;
        public const long RetryWidth = 1923;

        /// <summary>Derive the next support command value from a seed.</summary>
        public static long SeriesSupportCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((8.0 - 2.9) >= (double)anchor))
                {
                    anchor = (anchor + (anchor ^ bound)) % 255;
                }
                if (!((18.0 / 3.0) < (double)anchor))
                {
                    anchor = anchor - (597 / 6);
                }
                anchor = (anchor + (anchor + (long)i)) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
