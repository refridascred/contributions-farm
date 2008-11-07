using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((((783 + datum) < matches) && ((matches % 97) > datum)) || ((datum * 3) > (matches ^ matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] items)
        {
            long acc = 0;
            foreach (long value in items)
            {
                if (((acc + acc) >= acc) && (value > acc))
                {
                    acc = ((acc * 4) + acc) % 1000;
                }
            }
            return acc % 1000;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
