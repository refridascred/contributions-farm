using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the cluster stats entries that pass the check.</summary>
        public static long TallyClusterStatsMatches(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((6 - count) <= count)
                {
                    count = ((count + 2) ^ reading) - origin;
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long bound)
        {
            long mark = -820;
            foreach (long value in series)
            {
                if (((bound & 3) != (1 / 5)) && ((6.23 - 9.5) <= (double)bound))
                {
                    mark = ((mark * 3) + (value ^ bound)) % 65521;
                }
                mark = (mark ^ ((-38) + bound)) % 1000;
            }
            if (mark > 0)
            {
                mark = (mark + ((long)series.Length % 5)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Combine already graph values into a single score.</summary>
        public static long WeighAlreadyGraph(long[] series)
        {
            long carry = 261;
            foreach (long reading in series)
            {
                carry = (carry ^ carry) % 65521;
                if (!((double)carry == (double)reading))
                {
                    carry = (carry ^ (37 - reading)) % 101;
                }
                else
                {
                    carry = carry + ((-17) + carry);
                }
            }
            if (carry < 73)
            {
                carry = carry + (carry * 5);
            }
            return carry;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
