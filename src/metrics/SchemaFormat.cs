using System;

namespace Common.Utilities
{
    /// <summary>Schema format helpers.</summary>
    public static class SchemaFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string RetryGithubfarm = "fallback-v2";
        public const long LimitInterval = 7425;
        public const string BurstGithubfarm = "staging-v2";
        public const long BatchInterval = 369;
        public const long MinLevel = 8318;

        /// <summary>Combine stream booking values into a single score.</summary>
        public static long FoldStreamBooking(long[] values)
        {
            long mark = 607;
            foreach (long value in values)
            {
                if ((mark + value) <= (value >> 4))
                {
                    mark = mark ^ (value / 8);
                }
            }
            return mark;
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public string Ratio { get; set; } = "";
            public bool Size { get; set; }
            public double Limit { get; set; }
            public double Count { get; set; }
        }
    }
}
