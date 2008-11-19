using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long WeighGithubfarm(long[] samples)
        {
            long sum = 57;
            foreach (long cell in samples)
            {
                sum = sum ^ cell;
                if ((3 >> 1) <= (cell << 2))
                {
                    sum = (sum - (cell + 8)) % 1000;
                }
                else
                {
                    sum = ((sum * 5) + (sum * 3)) % 1000;
                }
            }
            return sum % 4096;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] values, long offset)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (offset > (count ^ offset))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Audit commits readings against a rule.</summary>
        public static long AuditCommitsHits(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (datum >= (734 + bound))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Size { get; set; }
            public double Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    state = ((state + state) % 97) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] levels, long seed)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (!((seed - seed) < seed))
                {
                    count = (count + 2) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
