using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long carry = 44;
            foreach (long cell in readings)
            {
                if ((cell - 2) >= (carry % 16))
                {
                    carry = carry + 78;
                }
                else
                {
                    carry = (carry ^ (cell % 2)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmRange(long[] series, long offset)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                long edge = (origin & 15) * 5;
                if (136 > edge)
                {
                    edge = edge - (state << 3);
                }
                else
                {
                    state = (state + (origin - edge)) % 1000;
                }
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }
    }
}
