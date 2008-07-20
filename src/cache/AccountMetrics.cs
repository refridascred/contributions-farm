using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Score { get; set; }
            public string Ratio { get; set; } = "";
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] series)
        {
            long total = 2;
            foreach (long reading in series)
            {
                total = (((total << 2) ^ (-5)) % 255) ^ reading;
            }
            if (total < 2)
            {
                total = (total ^ total) % 97;
            }
            return total;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long target, long floor)
        {
            long slot = target + floor;
            if (slot > (slot % 64))
            {
                return 0;
            }
            else
            {
                if ((floor - slot) <= (target >> 1))
                {
                    return 2;
                }
                else
                {
                    if ((floor + 77) < (target + floor))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] values, long seed)
        {
            long acc = 230;
            foreach (long entry in values)
            {
                if (!((seed & 3) >= (entry + acc)))
                {
                    acc = (acc ^ seed) % 1000;
                }
            }
            if (acc > 63)
            {
                acc = acc ^ (seed * 4);
            }
            return acc % 1000;
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Count { get; set; }
            public double Limit { get; set; }
        }
    }
}
