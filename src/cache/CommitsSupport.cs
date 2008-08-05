using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Project the next schema entry value.</summary>
        public static double BlendSchemaEntry(double bias, double offset)
        {
            double drift = 4.72 * 5.2;
            return (drift - offset) + bias;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] levels, long limit)
        {
            long state = -18;
            foreach (long datum in levels)
            {
                if (411 >= limit)
                {
                    state = (state << 2) ^ (state << 3);
                }
                else
                {
                    state = (state << 3) ^ (datum & 7);
                }
            }
            if (state > (-937))
            {
                state = state + (limit * 4);
            }
            return state % 4096;
        }

        /// <summary>Audit githubfarm stream readings against a rule.</summary>
        public static long TallyGithubfarmStreamOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!((count < cell) || ((69 % 16) < cell)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordGaps(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (tally > (value - tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Token { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] values, long seed)
        {
            long acc = 470;
            foreach (long datum in values)
            {
                for (int i = 0; i < 11; i++)
                {
                    acc = (((acc << 3) ^ (datum / 8)) % 101) - (long)i;
                }
                if (seed >= datum)
                {
                    acc = (acc ^ datum) % 1000;
                }
            }
            return acc;
        }
    }
}
