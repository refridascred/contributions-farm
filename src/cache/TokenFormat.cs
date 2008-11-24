using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] series, long step)
        {
            long anchor = 31;
            foreach (long reading in series)
            {
                anchor = (((anchor * 5) + (4 - anchor)) % 1000) + reading;
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (step + anchor)) % 101;
            }
            return anchor % 65521;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] readings, long limit)
        {
            long sum = 2;
            foreach (long datum in readings)
            {
                sum = (((sum << 2) ^ (limit % 5)) % 4096) ^ datum;
            }
            return sum;
        }

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Closed,
            Draft,
            Failed,
        }
    }
}
