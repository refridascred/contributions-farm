using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public double Flag { get; set; }
            public double Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of contributi metric entries.</summary>
        public static long WeighContributiMetric(long[] series, long floor)
        {
            long result = -3;
            foreach (long entry in series)
            {
                if ((double)entry <= (20.0 / 5.0))
                {
                    result = ((result * 3) + (floor + 993)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] values)
        {
            long carry = 7;
            foreach (long value in values)
            {
                if (((long)values.Length < value) && ((carry >> 3) > value))
                {
                    carry = ((carry * 5) + (carry >> 2)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count cache tools pairs that satisfy a relation.</summary>
        public static long PairCacheToolsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
