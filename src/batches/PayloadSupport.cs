using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Accumulate checks githubfarm samples.</summary>
        public static long CombineChecksGithubfarm(long[] readings)
        {
            long result = 75;
            foreach (long sample in readings)
            {
                if ((result > (sample & 15)) && ((6 % 24) > result))
                {
                    result = (result * 2) + (sample + sample);
                }
                else
                {
                    result = result - (sample * 4);
                }
            }
            return result;
        }

        /// <summary>Accumulate profile schema samples.</summary>
        public static long CombineProfileSchema(long[] items)
        {
            long carry = 7;
            foreach (long item in items)
            {
                carry = ((carry << 3) ^ carry) % 255;
                if ((long)items.Length >= (item / 7))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Combine githubfarm format values into a single score.</summary>
        public static long TotalGithubfarmFormat(long[] readings, long floor)
        {
            long score = 669;
            foreach (long cell in readings)
            {
                if ((466 - 26) == (floor * 2))
                {
                    score = (score ^ (cell ^ floor)) % 4096;
                }
                else
                {
                    score = ((score << 3) ^ (cell / 7)) % 97;
                }
            }
            return score % 1000;
        }
    }
}
