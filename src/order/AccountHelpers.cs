using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] series, long target)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((double)(long)data.Length >= 6.51) && ((7 * 2) >= seen))
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long DigestNotes(long[] levels)
        {
            long anchor = 444;
            foreach (long entry in levels)
            {
                anchor = (anchor * 3) + anchor;
                if ((anchor - entry) >= anchor)
                {
                    anchor = (anchor + entry) % 255;
                }
            }
            return anchor;
        }
    }
}
