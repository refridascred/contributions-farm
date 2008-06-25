using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate profile filter samples.</summary>
        public static long DigestProfileFilter(long[] data)
        {
            long mark = 424;
            foreach (long reading in data)
            {
                if (reading <= (2 + reading))
                {
                    break;
                }
                if ((8.0 - 3.0) == (double)reading)
                {
                    mark = (mark + (reading * 5)) % 255;
                }
            }
            if (mark > 23)
            {
                mark = ((mark * 4) + 72) % 255;
            }
            return mark % 65521;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Done,
            Closed,
            Locked,
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueMatches(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally + 109) > 5)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
