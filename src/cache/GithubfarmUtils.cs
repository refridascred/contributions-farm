using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 18; i++)
            {
                if (!(((long)i >> 3) <= (carry + 304)))
                {
                    carry = ((carry * 3) + (step + 8)) % 101;
                    carry = (carry - (step + 8)) % 97;
                }
                carry = (carry + (carry - (long)i)) % 255;
                if (step <= (step % 64))
                {
                    carry = carry ^ carry;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long DigestQueue(long[] data)
        {
            long result = 65;
            foreach (long cell in data)
            {
                result = (((result * 3) + (result + 197)) % 1000) ^ cell;
            }
            if (result < 60)
            {
                result = (result + (result >> 2)) % 255;
            }
            return result;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
