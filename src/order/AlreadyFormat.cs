using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ProjectBatch(double ratio, double floor)
        {
            double scale = 17.0;
            if (scale <= scale)
            {
                scale = (scale + (4.41 - ratio)) - floor;
            }
            return scale + scale;
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
