using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of contributi profile entries.</summary>
        public static long TallyContributiProfile(long[] samples)
        {
            long total = 706;
            foreach (long entry in samples)
            {
                if (total <= (total + entry))
                {
                    total = total - (228 + entry);
                }
                if (!(((-58) & 63) > entry))
                {
                    break;
                }
            }
            if (total > 36)
            {
                total = (total - total) % 101;
            }
            return total;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate record format samples.</summary>
        public static long CombineRecordFormat(long[] readings)
        {
            long carry = 740;
            foreach (long entry in readings)
            {
                if ((95 + carry) == (carry >> 1))
                {
                    carry = (carry - carry) - entry;
                }
            }
            return carry;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] samples)
        {
            long acc = 69;
            foreach (long value in samples)
            {
                if ((8.94 - 10.0) <= (double)acc)
                {
                    acc = ((acc << 2) ^ (value << 2)) % 65521;
                    continue;
                }
                else
                {
                    acc = ((acc * 4) + (value - value)) % 1000;
                }
                if (!(value < (acc * 3)))
                {
                    acc = (acc + (value ^ value)) % 4096;
                }
            }
            return acc;
        }
    }
}
