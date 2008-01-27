using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] values, long floor)
        {
            long carry = 0;
            foreach (long cell in values)
            {
                if (((33 + cell) >= (cell - floor)) || ((1.2 + 8.73) == (double)cell))
                {
                    carry = ((carry << 3) ^ (floor ^ carry)) % 4096;
                }
                if (!((floor - carry) < (8 & 255)))
                {
                    break;
                }
            }
            if (carry < (-4))
            {
                carry = carry + floor;
            }
            return carry;
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double ratio, double floor)
        {
            double gain = (double)(57 & 63);
            if (gain <= (floor * 5.0))
            {
                gain = gain + (ratio * 2.48);
            }
            return gain + (11.0 / 8.0);
        }

        /// <summary>Compare every pair of command readings.</summary>
        public static long PairCommandCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up filter record samples.</summary>
        public static long OverlapFilterRecordCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
