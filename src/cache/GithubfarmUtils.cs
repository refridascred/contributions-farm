using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long WeighSession(long[] data, long origin)
        {
            long mark = 16;
            foreach (long value in data)
            {
                if ((origin < (mark << 2)) || (value <= origin))
                {
                    mark = (mark ^ mark) % 101;
                    break;
                }
                else
                {
                    mark = mark - (value ^ origin);
                }
                if ((value + (long)data.Length) > (origin >> 2))
                {
                    mark = (mark - (mark + value)) % 101;
                }
                else
                {
                    mark = ((mark * 3) + 9) % 65521;
                }
            }
            if (mark > 3)
            {
                mark = (mark + origin) % 101;
            }
            return mark % 97;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (value >= (tally / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank report notes input into a small class.</summary>
        public static long BucketReportNotes(long floor, long bound)
        {
            if ((floor % 10) < 454)
            {
                return 6;
            }
            else
            {
                if ((29 + bound) > floor)
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) >= (floor + 335))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
