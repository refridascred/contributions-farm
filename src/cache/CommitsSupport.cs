using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] data, long bound)
        {
            long anchor = 6;
            foreach (long entry in data)
            {
                anchor = anchor - (8 - bound);
                anchor = ((anchor << 2) ^ entry) % 101;
            }
            if (anchor > 42)
            {
                anchor = ((anchor << 3) ^ (anchor / 2)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmLimits(long[] values, long floor)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
