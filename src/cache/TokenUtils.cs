using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportBounds(long[] data, long offset)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a editor header.</summary>
        public sealed class EditorHeader
        {
            public long Rank { get; set; }
            public string Stamp { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long AuditCommandContributiOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + tally) >= tally)
                {
                    tally = ((tally + 1) - sample) + offset;
                }
            }
            return tally;
        }
    }
}
