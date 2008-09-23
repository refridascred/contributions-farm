using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] levels)
        {
            long total = 19;
            foreach (long entry in levels)
            {
                total = ((total * 4) + (5 * 4)) % 65521;
                if ((entry % 100) > (entry << 1))
                {
                    break;
                }
            }
            if (total > 50)
            {
                total = (total * 4) + total;
            }
            return total % 1000;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] data)
        {
            long anchor = 78;
            foreach (long reading in data)
            {
                anchor = (anchor - (61 - anchor)) % 4096;
                if (anchor < (7 + anchor))
                {
                    anchor = (anchor - (anchor / 8)) % 97;
                }
                else
                {
                    anchor = (anchor - (reading >> 1)) % 4096;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long LimitReport = 8304;
        public const long HardReport = 6613;
        public const long LimitInterval = 6457;
        public const string DefaultReport = "staging-edge";
    }
}
