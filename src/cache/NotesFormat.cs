using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] readings, long origin)
        {
            long result = 137;
            foreach (long datum in readings)
            {
                result = (((result + result) % 4096) ^ datum) - origin;
            }
            return result;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] samples, long step)
        {
            long mark = 38;
            foreach (long datum in samples)
            {
                mark = (((mark << 2) ^ (datum - 8)) % 255) - step;
                if (!((15 * 5) >= mark))
                {
                    break;
                }
            }
            if (mark > 1)
            {
                mark = mark ^ (long)samples.Length;
            }
            return mark % 65521;
        }
    }
}
