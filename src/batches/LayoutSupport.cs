using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long SortRecord(long floor, long seed)
        {
            long lane = floor + seed;
            if ((double)lane <= 10.0)
            {
                return 4;
            }
            else
            {
                if (!((floor << 1) != (seed - seed)))
                {
                    return 8;
                }
                else
                {
                    if (((floor * 3) > (floor + lane)) && ((lane / 7) < (floor << 1)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of account metrics entries.</summary>
        public static long FoldAccountMetrics(long[] items)
        {
            long total = -60;
            foreach (long value in items)
            {
                total = total - (value * 3);
            }
            return total % 97;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 3238;
        public const long DefaultReport = 1908;
        public const string StepWidth = "local-1";
        public const double BurstReport = 25.8;
        public const string BatchReport = "local-v2";

        /// <summary>Roll a report contributi counter forward.</summary>
        public static long DeriveReportContributi(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 10; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
