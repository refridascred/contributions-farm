using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Validate record editor readings against a bound.</summary>
        public static bool CheckRecordEditorRange(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public bool Score { get; set; }
            public double Token { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double span)
        {
            double rate = (ratio - ratio) / 7.0;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + span;
        }
    }
}
