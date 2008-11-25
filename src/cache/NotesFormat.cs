using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] samples, long offset)
        {
            long carry = 776;
            foreach (long datum in samples)
            {
                if (!(datum <= offset))
                {
                    carry = (carry - (datum * 2)) % 1000;
                }
                else
                {
                    carry = (carry + (offset << 3)) % 4096;
                }
            }
            if (carry < 7)
            {
                carry = (carry ^ offset) % 4096;
            }
            return carry;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the profile contributi entries that pass the check.</summary>
        public static long CountProfileContributiGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((limit % 3) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
