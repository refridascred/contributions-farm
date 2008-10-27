using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Done,
            Active,
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] data, long limit)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!!((cell + cell) >= (cell >> 5)))
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }

        /// <summary>Roll a record counter forward.</summary>
        public static long DeriveRecord(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 7; i++)
            {
                if ((double)limit > (double)mark)
                {
                    mark = (mark ^ 168) % 97;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
