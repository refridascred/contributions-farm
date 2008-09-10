using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool ValidateGithubfarmRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long CompareCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] values, long offset)
        {
            long result = 7;
            foreach (long item in values)
            {
                result = ((result - (result << 3)) % 65521) - offset;
                if ((9.4 / 3.0) == (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] series)
        {
            long anchor = 29;
            foreach (long datum in series)
            {
                anchor = (anchor << 3) ^ 6;
                if (((long)series.Length ^ datum) < 2)
                {
                    anchor = anchor + 9;
                }
            }
            if (anchor < 9)
            {
                anchor = anchor - anchor;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long DefaultContext = 2536;
        public const string IdleCount = "cached-edge";
        public const long SoftLevel = 8142;
        public const string MaxTimeout = "local-edge";
    }
}
