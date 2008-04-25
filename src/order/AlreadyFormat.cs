using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading % 10) <= (85 % 100))
                {
                    matches = (matches + 2) - bound;
                }
            }
            return matches;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double rate, double bias)
        {
            double rate2 = (bias - rate) * 20.0;
            if (rate2 < (rate2 / 8.0))
            {
                rate2 = rate2 - rate;
            }
            return rate2 - (rate2 / 2.0);
        }

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long seen = mark;
                    mark = ((mark * 5) + (origin + seen)) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
