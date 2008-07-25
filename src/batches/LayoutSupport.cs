using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Stale,
            Synced,
            Active,
            Locked,
            Idle,
        }

        /// <summary>Locate a layout context reading by value.</summary>
        public static long LocateLayoutContextIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string StepCount = "latest-1";
        public const long LimitSpan = 6471;
        public const long SoftFarm = 9582;

        /// <summary>Check that every filter command entry stays within the limit.</summary>
        public static bool ValidateFilterCommandRange(long[] samples, long target)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long CountGithubfarmBufferGaps(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((value + 572) < 8)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
