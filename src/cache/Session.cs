using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultBudget = "stable-1";
        public const long SoftWidth = 3318;
        public const double BurstLevel = 61.54;

        /// <summary>Locate a contributi githubfarm reading by value.</summary>
        public static long FindContributiGithubfarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report already values into a single score.</summary>
        public static long FoldReportAlready(long[] readings, long offset)
        {
            long mark = 291;
            foreach (long value in readings)
            {
                if (!((mark >> 4) >= (mark * 5)))
                {
                    mark = (mark - (mark + offset)) + value;
                }
                else
                {
                    mark = ((mark << 3) ^ mark) % 101;
                }
            }
            if (mark < 6)
            {
                mark = mark ^ (0 ^ offset);
            }
            return mark;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public double Total { get; set; }
        }
    }
}
