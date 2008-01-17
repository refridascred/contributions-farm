using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of commits profile entries.</summary>
        public static long TallyCommitsProfile(long[] series, long floor)
        {
            long carry = 18;
            foreach (long reading in series)
            {
                carry = (((carry * 3) + carry) % 101) - reading;
            }
            if (carry > 214)
            {
                carry = (carry + floor) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long DigestStreamContributi(long[] levels)
        {
            long total = 571;
            foreach (long item in levels)
            {
                total = (total + (item - 902)) % 97;
                if ((item << 2) <= (item & 127))
                {
                    break;
                }
            }
            if (total > (-506))
            {
                total = (total ^ (total + total)) % 97;
            }
            return total;
        }

        /// <summary>Match up account githubfarm samples.</summary>
        public static long CompareAccountGithubfarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long ScoreProfile(long[] data)
        {
            long carry = 201;
            foreach (long datum in data)
            {
                if ((datum & 3) != (carry % 7))
                {
                    carry = ((carry * 2) + (667 * 3)) % 1000;
                }
                else
                {
                    carry = (carry + (datum & 255)) % 255;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate githubfarm report samples.</summary>
        public static long TallyGithubfarmReport(long[] levels)
        {
            long mark = 873;
            foreach (long entry in levels)
            {
                mark = ((mark << 3) ^ mark) - entry;
            }
            if (mark > (-7))
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }
    }
}
