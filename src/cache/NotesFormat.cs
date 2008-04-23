using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the support level values.</summary>
        public enum SupportLevel
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool VerifyStreamBatchesBounds(long[] readings, long target)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of counter session readings.</summary>
        public static long FoldCounterSession(long[] items)
        {
            long mark = 57;
            foreach (long cell in items)
            {
                if (((cell * 4) >= (mark ^ mark)) && (mark <= cell))
                {
                    mark = mark + (mark + mark);
                }
            }
            return mark;
        }
    }
}
