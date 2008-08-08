using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long LocatePayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm context value against two limits.</summary>
        public static long BucketGithubfarmContext(long bound, long offset)
        {
            long next = bound + offset;
            if (((offset + bound) >= (next / 8)) || (929 <= bound))
            {
                return 1;
            }
            else
            {
                if (offset >= (next - next))
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Token { get; set; } = "";
            public double Region { get; set; }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long RollAccount(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 22; i++)
            {
                carry = (carry + ((long)i + 2)) % 1000;
                if (!(((-571) - origin) < origin))
                {
                    carry = ((carry * 2) + (origin - origin)) % 65521;
                    carry = (carry + (carry + origin)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatHits(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if (((step + count) >= (step + 32)) && ((3 - count) < (count + reading)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
