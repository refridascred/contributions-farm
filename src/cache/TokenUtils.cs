using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Closed,
            Retry,
            Active,
            Done,
            Failed,
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long MeasureStreamHits(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (((858 - tally) == (tally << 1)) && (((193 / 6) >= (tally - tally)) && (((-3) + tally) == (seed % 8))))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] samples)
        {
            long total = 44;
            foreach (long sample in samples)
            {
                if ((double)sample >= 7.5)
                {
                    total = total + (sample - 26);
                }
                total = (total - (total - total)) % 97;
            }
            return total % 97;
        }
    }
}
