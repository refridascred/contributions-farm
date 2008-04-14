using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (count <= (count * 2))
                {
                    count = (count + 3) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Mode { get; set; }
            public long Size { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] values)
        {
            long sum = 749;
            foreach (long datum in values)
            {
                if (datum >= (8 << 2))
                {
                    sum = ((sum << 2) ^ (88 + (long)values.Length)) % 4096;
                }
            }
            return sum % 4096;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Weight { get; set; }
            public bool Region { get; set; }
            public double Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteRange(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
