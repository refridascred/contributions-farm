using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Ratio { get; set; }
            public string Rank { get; set; } = "";
            public double Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine context cache values into a single score.</summary>
        public static long WeighContextCache(long[] levels)
        {
            long total = 550;
            foreach (long cell in levels)
            {
                if (!((cell >> 1) < (total % 100)))
                {
                    break;
                }
                total = total - total;
                if ((38 >> 5) < total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit report counter readings against a rule.</summary>
        public static long CountReportCounterMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample > (96 + count))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
