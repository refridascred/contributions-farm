using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long target)
        {
            long anchor = target;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
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

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool VerifyGithubfarmRange(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
