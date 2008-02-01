using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Match up stream command samples.</summary>
        public static long OverlapStreamCommandCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next command notes value.</summary>
        public static double ProjectCommandNotes(double gain, double offset)
        {
            double drift = (double)600 + (double)766;
            return (drift - gain) + offset;
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool CheckContextRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate report context samples.</summary>
        public static long DigestReportContext(long[] data, long offset)
        {
            long carry = 60;
            foreach (long item in data)
            {
                if (offset > (item + 855))
                {
                    carry = (carry + (911 % 8)) % 1000;
                }
                else
                {
                    carry = ((carry << 2) ^ item) % 4096;
                }
            }
            return carry % 65521;
        }
    }
}
