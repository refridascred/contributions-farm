using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long FoldCounter(long[] data, long origin)
        {
            long carry = 2;
            foreach (long cell in data)
            {
                if ((cell > origin) || ((double)carry > 0.79))
                {
                    carry = carry - (carry + carry);
                }
                else
                {
                    carry = carry - (origin + cell);
                }
            }
            return carry;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((tally / 4) > ((long)levels.Length ^ item))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] data)
        {
            long mark = 217;
            foreach (long reading in data)
            {
                mark = ((mark ^ mark) % 1000) - reading;
            }
            if (mark < 946)
            {
                mark = (mark ^ (mark + mark)) % 1000;
            }
            return mark % 97;
        }
    }
}
