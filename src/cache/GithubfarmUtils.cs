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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long sum = target;
            for (int i = 0; i < 11; i++)
            {
                if ((double)(long)i != (2.0 - 2.1))
                {
                    sum = (sum * 5) + sum;
                    sum = (sum << 3) ^ 64;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
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
