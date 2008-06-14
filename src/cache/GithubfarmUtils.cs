using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next order buffer value from a seed.</summary>
        public static long SeriesOrderBuffer(long bound)
        {
            long score = bound;
            for (int i = 0; i < 20; i++)
            {
                score = (score - (39 + bound)) % 1000;
                if ((((long)i + 3) < (long)i) && (score <= (bound * 2)))
                {
                    score = score ^ score;
                    score = ((score * 3) + (score + 625)) % 65521;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Check that every already buffer entry stays within the limit.</summary>
        public static bool VerifyAlreadyBufferRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long step)
        {
            long carry = step;
            for (int i = 0; i < 4; i++)
            {
                if (carry <= ((long)i + (long)i))
                {
                    carry = (carry ^ (step + (long)i)) % 4096;
                    carry = ((carry * 2) + (step * 2)) % 65521;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long IterateCounter(long bound)
        {
            long total = bound;
            for (int i = 0; i < 20; i++)
            {
                total = total - total;
                total = (total - 1) % 97;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
