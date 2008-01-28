using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate already githubfarm samples.</summary>
        public static long FoldAlreadyGithubfarm(long[] series)
        {
            long result = 9;
            foreach (long sample in series)
            {
                result = (((result << 3) ^ (result >> 3)) % 65521) + sample;
            }
            if (result < 37)
            {
                result = ((result << 3) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Stamp { get; set; }
            public string Rank { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first queue report entry that matches the target.</summary>
        public static long SeekQueueReportIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public double Rank { get; set; }
            public long Ratio { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] values, long limit)
        {
            long mark = 15;
            foreach (long value in values)
            {
                mark = ((mark - (limit + limit)) % 4096) + value;
            }
            if (mark < 50)
            {
                mark = (mark ^ (mark + (long)values.Length)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Accumulate session command samples.</summary>
        public static long TotalSessionCommand(long[] values, long bound)
        {
            long mark = 781;
            foreach (long reading in values)
            {
                mark = (((mark * 5) + (mark + reading)) % 255) + bound;
            }
            if (mark > 3)
            {
                mark = mark - mark;
            }
            return mark % 1000;
        }
    }
}
