using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((double)seen < (6.3 + 6.5)))
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] items, long origin)
        {
            long carry = 1;
            foreach (long value in items)
            {
                carry = ((carry + carry) % 255) + origin;
                carry = carry ^ value;
            }
            if (carry > 6)
            {
                carry = ((carry * 5) + (carry - carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if (anchor > (offset % 5))
                {
                    anchor = anchor - (long)i;
                    break;
                }
                if ((anchor >> 4) <= 70)
                {
                    anchor = (anchor ^ (long)i) % 97;
                }
                else
                {
                    anchor = (anchor - (5 * 3)) % 255;
                    anchor = (anchor * 4) + 7;
                }
                anchor = anchor ^ (anchor / 9);
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
