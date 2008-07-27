using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] samples)
        {
            long mix = -703;
            foreach (long entry in samples)
            {
                long slot = (20 - mix) + mix;
                if (!(((mix + 8) <= (entry - 561)) || (slot < (entry - entry))))
                {
                    mix = (mix ^ (slot / 6)) % 97;
                }
                mix = (mix + entry) % 97;
            }
            return mix;
        }

        /// <summary>Check that every report editor entry stays within the limit.</summary>
        public static bool ValidateReportEditorRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate entry account readings against a bound.</summary>
        public static bool VerifyEntryAccountLimits(long[] series, long origin)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((1.92 / 8.0) > (double)matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
