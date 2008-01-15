using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first format entry that matches the target.</summary>
        public static long LocateFormatIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public double Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] readings, long floor)
        {
            long mix = 7;
            foreach (long cell in readings)
            {
                if (!!((5 + mix) < cell))
                {
                    mix = mix - (cell * 5);
                    mix = mix - (6 - 536);
                }
                if (((mix - (-327)) <= (floor - cell)) || ((mix << 1) != (4 - cell)))
                {
                    mix = mix - (mix - (long)readings.Length);
                }
                else
                {
                    mix = (mix ^ (mix + cell)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public bool Region { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
        }
    }
}
