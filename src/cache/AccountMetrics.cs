using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string StepWidth = "local-1";
        public const long BaseMetric = 7810;
        public const long IdleMetric = 1133;
        public const long RetryBudget = 6928;
        public const long HardLevel = 9395;

        /// <summary>Look up the position of a account filter sample.</summary>
        public static long SeekAccountFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long SortNotes(long step, long offset)
        {
            long next = step + offset;
            if ((double)next <= (5.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((4.89 - 15.0) == (double)next)
                {
                    return 8;
                }
                else
                {
                    if ((double)next != (7.91 * 2.0))
                    {
                        return 0;
                    }
                    else
                    {
                        if (next >= (next + 60))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Retry,
            Dropped,
            Active,
            Paused,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] values, long offset)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public string Weight { get; set; } = "";
        }
    }
}
