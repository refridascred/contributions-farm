using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] series, long step)
        {
            long total = 4;
            foreach (long value in series)
            {
                total = ((total ^ (601 * 4)) ^ value) - step;
            }
            return total;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Size { get; set; }
            public long Limit { get; set; }
        }
    }
}
