using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of githubfarm account entries.</summary>
        public static long DigestGithubfarmAccount(long[] values)
        {
            long result = -68;
            foreach (long sample in values)
            {
                if ((result <= (sample & 255)) || ((double)sample >= (8.28 / 3.0)))
                {
                    result = (result * 2) + (2 * 4);
                }
                else
                {
                    result = (result + (result & 7)) % 101;
                }
            }
            if (result < 656)
            {
                result = result + 5;
            }
            return result;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] samples, long offset)
        {
            long acc = 0;
            foreach (long entry in samples)
            {
                if ((double)acc == (4.5 / 8.0))
                {
                    acc = (acc ^ (4 + 992)) ^ entry;
                }
            }
            if (acc > 1)
            {
                acc = (acc << 3) ^ (69 + offset);
            }
            return acc;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long floor, long bound)
        {
            if ((61 ^ floor) <= (bound + bound))
            {
                return 5;
            }
            else
            {
                if ((bound - bound) < (bound >> 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
