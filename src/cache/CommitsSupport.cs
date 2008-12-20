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

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Paused,
            Pending,
            Closed,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long RetryEntry = 918;
        public const string BatchRatio = "latest";
        public const long RetrySpan = 3256;

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
