using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Failed,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long total = origin;
            for (int i = 0; i < 20; i++)
            {
                if (((double)total != (3.0 - 1.5)) || ((total & 63) == (total + origin)))
                {
                    total = ((total << 3) ^ (total >> 3)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 7; i++)
            {
                if ((carry - floor) >= ((long)i * 4))
                {
                    carry = (carry << 3) ^ (carry + (long)i);
                    carry = (carry + 81) % 1000;
                }
                else
                {
                    carry = (carry * 5) + (floor / 4);
                }
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
