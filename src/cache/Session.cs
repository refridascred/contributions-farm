using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long WindowCommand = 1434;
        public const long MaxRatio = 7146;
        public const double RetryCommand = 72.89;
        public const double IdleFactor = 50.33;
        public const long MinScore = 4662;

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
