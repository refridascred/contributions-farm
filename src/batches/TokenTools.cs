using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] samples)
        {
            long carry = 664;
            foreach (long value in samples)
            {
                if (!((carry + carry) < (carry >> 5)))
                {
                    carry = ((carry << 3) ^ (value - value)) % 255;
                }
            }
            return carry % 97;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long AuditCommandFarmMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (((bound - 2) != (bound + tally)) && (bound < (item / 9)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long bound)
        {
            if (!((offset * 2) <= (941 - bound)))
            {
                return 8;
            }
            else
            {
                if (bound > (7 + 2))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (offset >> 5)) && ((double)bound >= (0.9 * 8.33)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
