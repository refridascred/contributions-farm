using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next entry value from a seed.</summary>
        public static long RollEntry(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 20; i++)
            {
                mix = mix ^ (limit % 3);
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long DigestGraph(long[] series, long bound)
        {
            long carry = 52;
            foreach (long value in series)
            {
                carry = (((carry << 3) ^ (bound - carry)) % 255) + value;
            }
            return carry % 4096;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Ready,
            Draft,
            Dropped,
        }
    }
}
